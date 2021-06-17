using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VeganStore.Data;
using VeganStore.Models;

namespace VeganStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productrepository;

        public HomeController(IProductRepository productrepository)
        {
            _productrepository = productrepository;
        }

        public IActionResult Index()
        {
            return View(_productrepository);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
