using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.AggregateModels
{
    public class Address
    {
        public String Street { get; private set; }
        public String City { get; private set; }
        public Address(string street, string city)
        {
            Street = street;
            City = city;
        }
    }
}
