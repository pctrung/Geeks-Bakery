using AutoMapper;
using GeeksBakery.Data.Entities;
using GeeksBakery.ViewModels.Catalog.CakeImage;
using GeeksBakery.ViewModels.Requests;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.Requests.CakeImage;
using GeeksBakery.ViewModels.Requests.Category;
using GeeksBakery.ViewModels.Requests.Review;
using GeeksBakery.ViewModels.ViewModels;

namespace GeeksBakery.BackendApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Review, ReviewViewModel>().ForMember(des => des.UserAvatar, act => act.MapFrom(src => src.User.Avatar));
            CreateMap<Review, ReviewViewModel>().ForMember(des => des.Username, act => act.MapFrom(src => src.User.Name));
            CreateMap<ReviewCreateRequest, Review>();

            CreateMap<CakeImage, CakeImageViewModel>();
            CreateMap<CakeImageCreateRequest, CakeImage>();

            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryCreateRequest, Category>();

            CreateMap<CakeCreateRequest, Cake>();
        }
    }
}