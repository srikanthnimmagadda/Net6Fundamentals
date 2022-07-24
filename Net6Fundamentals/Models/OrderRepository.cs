namespace Net6Fundamentals.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ShopDbContext _shopDbContext;
        private readonly IShoppingCart _shoppingCart;

        public OrderRepository(ShopDbContext shopDbContext, IShoppingCart shoppingCart)
        {
            _shopDbContext = shopDbContext;
            _shoppingCart = shoppingCart;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();
            foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Pie.PieId,
                    Price = shoppingCartItem.Pie.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _shopDbContext.Orders.Add(order);
            _shopDbContext.SaveChanges();
        }
    }
}
