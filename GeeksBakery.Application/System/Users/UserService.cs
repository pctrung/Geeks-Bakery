using AutoMapper;
using GeeksBakery.Application.Interfaces;
using GeeksBakery.Data.EF;
using GeeksBakery.Data.Entities;
using GeeksBakery.Utilities.Extensions;
using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.System.Users;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly GeeksBakeryDbContext _context;
        private readonly IMapper _mapper;

        private readonly IConfiguration _configuration;
        private readonly IStorageService _storageService;

        private const int DEFAULT_LIMIT = 100;

        public UserService(IMapper mapper, GeeksBakeryDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, IConfiguration configuration, IStorageService storageService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _storageService = storageService;
            _context = context;
            _mapper = mapper;
        }

        public async Task<string> AuthenticateAsync(LoginRequest request)
        {
            var username = request.Username;

            // check email is match if user type email
            var emailCheck = await _context.Users.FirstOrDefaultAsync(x => x.Email == request.Username);
            if (emailCheck != null)
            {
                username = emailCheck.UserName;
            }

            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
            {
                return null;
            }

            var result = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return null;
            }

            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Role, string.Join(";", roles))
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Tokens: Issuer"],
                _configuration["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<ApiResult<bool>> DeleteAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return new ApiErrorResult<bool>("Not exists user id: " + id);
            }
            // delete avatar file
            await _storageService.DeleteFileAsync(user.Avatar);

            var reult = await _userManager.DeleteAsync(user);
            if (reult.Succeeded)
                return new ApiSuccessResult<bool>();

            return new ApiErrorResult<bool>("Delete failed");
        }

        public async Task<ApiResult<UserViewModel>> GetByIdAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return new ApiErrorResult<UserViewModel>("Not exists user id: " + id);
            }

            var roles = await _userManager.GetRolesAsync(user);

            var userViewModel = _mapper.Map<UserViewModel>(user);

            userViewModel.Roles = roles;

            return new ApiSuccessResult<UserViewModel>(userViewModel);
        }

        public async Task<ApiResult<PagedResult<UserViewModel>>> GetUsersPagingAsync(GetUserPagingRequest request)
        {
            var query = _userManager.Users;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.UserName.Contains(request.Keyword)
                || x.Name.Contains(request.Keyword)
                || x.Email.Contains(request.Keyword)
                || x.PhoneNumber.Contains(request.Keyword));
            }

            //Paging
            int totalRow = await query.CountAsync();

            request.Limit = request.Limit > 0 ? request.Limit : DEFAULT_LIMIT;
            request.Page = request.Page > 0 ? request.Page : 1;

            // extention method paged
            query = query.Paged(request.Page, request.Limit);

            var users = await query.ToListAsync();

            var userViewModels = _mapper.Map<List<UserViewModel>>(users);

            //Select and projection
            var pagedResult = new PagedResult<UserViewModel>()
            {
                TotalRecords = totalRow,
                Page = request.Page,
                Limit = request.Limit,
                Items = userViewModels
            };
            return new ApiSuccessResult<PagedResult<UserViewModel>>(pagedResult);
        }

        public async Task<IdentityResult> RegisterAsync(RegisterRequest request)
        {
            var user = new AppUser()
            {
                Name = request.Name,
                Email = request.Email,
                UserName = request.Username,
                Avatar = "default.png"
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            return result;
        }

        public async Task<ApiResult<bool>> RoleAssignAsync(Guid id, RoleAssignRequest request)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return new ApiErrorResult<bool>("Account does not exist");
            }
            var removedRoles = request.Roles.Where(x => x.Selected == false).Select(x => x.Name).ToList();
            foreach (var roleName in removedRoles)
            {
                if (await _userManager.IsInRoleAsync(user, roleName) == true)
                {
                    await _userManager.RemoveFromRoleAsync(user, roleName);
                }
            }
            await _userManager.RemoveFromRolesAsync(user, removedRoles);

            var addedRoles = request.Roles.Where(x => x.Selected).Select(x => x.Name).ToList();
            foreach (var roleName in addedRoles)
            {
                if (await _userManager.IsInRoleAsync(user, roleName) == false)
                {
                    await _userManager.AddToRoleAsync(user, roleName);
                }
            }

            return new ApiSuccessResult<bool>();
        }

        public async Task<ApiResult<bool>> UpdateAsync(UserUpdateRequest request)
        {
            if (await _userManager.Users.AnyAsync(x => x.Email == request.Email && x.Id != request.Id))
            {
                return new ApiErrorResult<bool>("Email already exists!");
            }
            var user = await _userManager.FindByIdAsync(request.Id.ToString());
            user.Address = request.Address;
            user.Email = request.Email;
            user.DoB = request.DoB;
            user.Name = request.Name;
            user.PhoneNumber = request.PhoneNumber;

            // update avatar if file not null
            if (request.Avatar != null)
            {
                var filePath = await SaveFileAsync(request.Avatar);

                if (!string.IsNullOrEmpty(filePath))
                {
                    await _storageService.DeleteFileAsync(user.Avatar);
                    user.Avatar = filePath;
                }
            }

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<bool>();
            }
            return new ApiErrorResult<bool>("Cập nhật không thành công");
        }

        private async Task<string> SaveFileAsync(IFormFile file)
        {
            if (file == null)
            {
                return string.Empty;
            }
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}