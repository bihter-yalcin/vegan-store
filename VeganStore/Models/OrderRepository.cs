using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganStore.Data;

namespace VeganStore.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(ApplicationDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            var shoppingcartitems = _shoppingCart.ShoppingCartItems;
            order.total = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach (var item in shoppingcartitems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = item.Amount,
                    ProductId = item.Product.ProductId,
                    Price = item.Product.Price
                };


                order.OrderDetails.Add(orderDetail);

            }

            _appDbContext.Orders.Add(order);

            _appDbContext.SaveChanges();

        }






    }
}
