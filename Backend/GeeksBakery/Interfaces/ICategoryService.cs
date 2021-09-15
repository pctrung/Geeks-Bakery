using GeeksBakery.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAllAsync();
    }
}