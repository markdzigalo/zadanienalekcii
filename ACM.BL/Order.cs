using System;
using System.Collections.Generic;

namespace CMS.BL
{
    public class Order
    {
        public int OrderId { get; private set; }
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public Order() : this(0) { }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}