using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.AggregateModels
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Address Address { get; private set; }
        public Order(DateTime orderDate, Address address)
        {
            OrderDate = orderDate;
            Address = address;
        }
    }
}
