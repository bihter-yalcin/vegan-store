using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeganStore.Models
{
   public  interface IProductRepository
    {
        public IEnumerable<Product> ProductList { get;  }
        public IEnumerable<Product> PopularProducts { get;  }

        IEnumerable<Product> GetCategoryProducts(int a);

        Product GetProductById(int a);

        Product GetProductByName(string a);

    }
}
