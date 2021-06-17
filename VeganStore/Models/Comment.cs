using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VeganStore.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [DisplayName("Comment")]
        public string comment { get; set; }

        [DisplayName("Product Name")]
        public int ProductId { get; set; }

        [NotMapped]
        public List<Product> ProductCollection { get; set; }

    }
}
