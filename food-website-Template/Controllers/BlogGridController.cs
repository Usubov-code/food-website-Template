using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace food_website_Template.Controllers
{
    public class BlogGridController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
