using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganStore.Data;

namespace VeganStore.Models
{
    public class CommentRepo : IComment
    {

        private readonly ApplicationDbContext _appDbContext;

        public CommentRepo(ApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }

        public IEnumerable<Comment> AllComments
        {
            get
            {
                //category alsın diye include
                return _appDbContext.Comments;
            }
        }

        public IEnumerable<Product> AllProduct
        {
            get
            {
                //category alsın diye include
                return _appDbContext.Products;
            }
        }
        public IEnumerable<Comment> Getcommentlistbyid(int productId)
        {
            IEnumerable<Comment> objList = from comment in AllComments
                                           where comment.ProductId == productId
                                           select comment;
      

            return objList;
        }
    }
}
