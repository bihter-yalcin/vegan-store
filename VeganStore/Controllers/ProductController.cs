using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganStore.Models;
using VeganStore.ViewModels;

namespace VeganStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            return View(_productRepository);
        }

        public IActionResult MakeUpCategory()
        {
            return View(_productRepository);
        }

        public IActionResult FoodCategory()
        {
            return View(_productRepository);
        }

        public IActionResult SkincareCategory()
        {
            return View(_productRepository);
        }


        public IActionResult FragranceCategory()
        {
            return View(_productRepository);
        }


        public IActionResult HairCategory()
        {
            return View(_productRepository);
        }


        public IActionResult BathAndBodyCategory()
        {
            return View(_productRepository);
        }


        public IActionResult ToolsAndBrushesCategory()
        {
            return View(_productRepository);
        }


        public IActionResult Detail(int a)
        {
            //var productdetail = _productRepository.ProductList.FirstOrDefault(p => p.ProductId == a);

            return View(_productRepository);
        }

        // public IActionResult SearchResult (string ProductSearch) {

        //   ViewData(GetProductByName) = ProductSearch;

        //}

        public IActionResult Details(int id)
        {
          
            var Details = new DetailsViewModel
            {
                Product = _productRepository.GetProductById(id)
                 
              };  
         

            return View(Details);
        }
       


    }
}

