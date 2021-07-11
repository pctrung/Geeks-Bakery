using AutoMapper;
using GeeksBakery.Application.Interfaces;
using GeeksBakery.Data.EF;
using GeeksBakery.Data.Entities;
using GeeksBakery.Utilities.Exceptions;
using GeeksBakery.ViewModels.Requests.Review;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Services
{
    public class ReviewService : IReviewService
    {
        private readonly GeeksBakeryDbContext _context;
        private readonly IMapper _mapper;

        public ReviewService(GeeksBakeryDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> CreateAsync(ReviewCreateRequest request)
        {
            var review = _mapper.Map<Review>(request);
            review.DateCreated = DateTime.Now;

            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
            return review.Id;
        }

        public async Task<int> DeleteAsync(int reviewId)
        {
            var review = await _context.Reviews.FindAsync(reviewId);

            if (review == null)
            {
                throw new GeeksBakeryException($"Cannot find review with Id: {review}");
            }

            _context.Reviews.Remove(review);

            return await _context.SaveChangesAsync();
        }

        public async Task<List<ReviewViewModel>> GetByCakeIdAsync(int cakeId)
        {
            var reviews = await _context.Reviews.Where(x => x.CakeId == cakeId).Include(x => x.User).ToListAsync();

            var result = _mapper.Map<List<ReviewViewModel>>(reviews);

            return result;
        }

        public async Task<ReviewViewModel> GetByIdAsync(int reviewId)
        {
            var review = await _context.Reviews.Where(x => x.Id == reviewId).Include(x => x.User).FirstOrDefaultAsync();

            var result = _mapper.Map<ReviewViewModel>(review);

            return result;
        }
    }
}