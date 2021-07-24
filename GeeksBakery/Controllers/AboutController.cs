using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("https://github.com/trungxiit");
        }
    }
}