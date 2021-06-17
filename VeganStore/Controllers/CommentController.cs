using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganStore.Data;
using VeganStore.Models;
using VeganStore.ViewModels;

namespace VeganStore.Controllers
{
    public class CommentController : Controller
    {

        private readonly IComment _comment;

        private readonly ApplicationDbContext b;
        public CommentController(IComment comment, ApplicationDbContext a)
        {
            _comment = comment;
            b = a;
        }


        public ViewResult Index()
        {
            return View();
        }


        public IActionResult a(int id)

        {

            IEnumerable<Product> product = from a in b.Products
                                   where a.ProductId == id
                                   select a;

            var commentviewmodel = new CommentViewModel
            {
                Products = product,

                Comments = _comment.Getcommentlistbyid(id)
            };


            return View(commentviewmodel);
        }




        public IActionResult Add(int id = 0)
        {

            Comment c = new Comment();

            c.ProductCollection = _comment.AllProduct.ToList();

            return View(c);
        }


        [HttpPost]
        public IActionResult Add(Comment obj)
        {

            if (ModelState.IsValid)
            {
                b.Comments.Add(obj);
                b.SaveChanges();

                return RedirectToAction("Index");


            }
            return View(obj);

        }



    }
}
