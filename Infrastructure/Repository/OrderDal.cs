using Domain.AggregateModels;
using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class OrderDal
    {
        private List<Order> _mockDB;

        public OrderDal()
        {
            _mockDB = new List<Order>()
            {
                new Order(DateTime.Now, new Address("rue pasteur", "Le Kremlin Bicetre"))
                {
                    Id=1
                },
                new Order(DateTime.Now, new Address("champs elysé", "Paris"))
                {
                    Id=3
                },
                new Order(DateTime.Now, new Address("rue voltaire", "Le Kremlin Bicetre"))
                {
                    Id=4
                },
                new Order(DateTime.Now, new Address("rue de la convention", "Le Kremlin Bicetre"))
                {
                    Id=2
                }
            };
        }
        public IReadOnlyList<Order> Find(Specification<Order> spec)
        {
            return _mockDB.AsQueryable().Where(spec.ToExpression()).ToList();
        }
    }
}
