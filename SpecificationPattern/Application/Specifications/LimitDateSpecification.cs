using Domain.AggregateModels;
using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SpecificationPattern.Application.Specifications
{
    public class LimitDateSpecification : Specification<Order>
    {
        DateTime _date;
        public LimitDateSpecification(DateTime date)
        {
            _date = date;
        }
        public override Expression<Func<Order, bool>> ToExpression() =>
            order => _date >= order.OrderDate;
    }
}
