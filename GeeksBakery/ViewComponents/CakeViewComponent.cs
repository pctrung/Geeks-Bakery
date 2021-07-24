using GeeksBakery.ViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.ViewComponents
{
    public class CakeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(CakeViewModel cake)
        {
            return View(cake);
        }
    }
}