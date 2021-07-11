using AutoMapper;
using GeeksBakery.Application.Interfaces;
using GeeksBakery.Data.EF;
using GeeksBakery.Data.Entities;
using GeeksBakery.Utilities.Exceptions;
using GeeksBakery.ViewModels.Requests.Category;
using GeeksBakery.ViewModels.Requests.Rate;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Services
{
    public class RateService : IRateService
    {
        private readonly GeeksBakeryDbContext _context;
        private readonly IMapper _mapper;

        public RateService(GeeksBakeryDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> CreateAsync(RateCreateRequest request)
        {
            var rate = _mapper.Map<Rate>(request);
            rate.DateCreated = DateTime.Now;

            await _context.Rates.AddAsync(rate);
            return rate.Id;
        }

        public async Task<int> DeleteAsync(int rateId)
        {
            var rate = await _context.Rates.FindAsync(rateId);

            if (rate == null)
            {
                throw new GeeksBakeryException($"Cannot find rate with Id: {rate}");
            }

            _context.Rates.Remove(rate);

            return await _context.SaveChangesAsync();
        }

        public async Task<List<RateViewModel>> GetByCakeIdAsync(int cakeId)
        {
            var rates = await _context.Rates.Where(x => x.CakeId == cakeId).ToListAsync();

            var result = _mapper.Map<List<RateViewModel>>(rates);

            return result;
        }

        public async Task<RateViewModel> GetByIdAsync(int rateId)
        {
            var rates = await _context.Rates.FindAsync(rateId);

            var result = _mapper.Map<RateViewModel>(rates);

            return result;
        }
    }
}