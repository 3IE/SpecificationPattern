using Domain.AggregateModels;
using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SpecificationPattern.Application.Specifications
{
    public class CitySpecification : Specification<Order>
    {
        private string _city;
        public CitySpecification(string city)
        {
            _city = city;
        }
        public override Expression<Func<Order, bool>> ToExpression() => 
            order => order.Address.City.ToLower() == _city.ToLower();
        
    }
}
