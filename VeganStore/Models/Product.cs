using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeganStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public string BrandName { get; set; }

        public string Description { get; set; }

        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public bool InStock { get; set; }

        public bool IsPopular { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
