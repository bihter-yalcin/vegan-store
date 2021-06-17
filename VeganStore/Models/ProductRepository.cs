using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganStore.Data;

namespace VeganStore.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
 

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;

        }

        public IEnumerable<Product> ProductList {
            get => _db.Products.Include(c => c.Category);
        }
        public IEnumerable<Product> PopularProducts { get => _db.Products.Include(c => c.Category).Where(p=>p.IsPopular); }

        public IEnumerable<Product> GetCategoryProducts(int a)
        {
            return _db.Products.Include(c=>c.Category).Where(p =>p.CategoryId==a);

        }

        public Product GetProductById(int a)
        {
            return _db.Products.FirstOrDefault(p => p.ProductId == a);
        }

        public Product GetProductByName(string a)
        {
            return _db.Products.FirstOrDefault(p => p.ProductName == a);
        }


    }
}
