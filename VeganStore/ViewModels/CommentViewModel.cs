using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganStore.Models;

namespace VeganStore.ViewModels
{
    public class CommentViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Comment> Comments { get; set; }

    }
}
