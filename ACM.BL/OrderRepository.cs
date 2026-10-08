using System;

namespace CMS.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 0, 0, new TimeSpan(3, 0, 0));
            }

            return order;
        }

        public bool Save(Order order)
        {
            var success = true;

            if (order.Validate())
            {
                if (order.OrderId == 0)
                {
                   
                }
                else
                {
                    
                }
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}