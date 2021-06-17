using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeganStore.Models
{
    public interface IComment
    {
        IEnumerable<Comment> AllComments { get; }
        IEnumerable<Comment> Getcommentlistbyid(int productId);
        IEnumerable<Product> AllProduct { get; }
    }
}
