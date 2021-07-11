using AutoMapper;
using GeeksBakery.Data.Entities;
using GeeksBakery.ViewModels.Catalog.CakeImage;
using GeeksBakery.ViewModels.Requests;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.Requests.Category;
using GeeksBakery.ViewModels.Requests.Rate;
using GeeksBakery.ViewModels.ViewModels;

namespace GeeksBakery.BackendApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Rate, RateViewModel>();
            CreateMap<CakeImage, CakeImageViewModel>();
            CreateMap<Category, CategoryViewModel>();

            CreateMap<CategoryCreateRequest, Category>();
            CreateMap<RateCreateRequest, Rate>();
            CreateMap<CakeCreateRequest, Cake>();
        }
    }
}