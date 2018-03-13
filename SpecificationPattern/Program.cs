using SpecificationPattern.Application.Specifications;
using System;

namespace SpecificationPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = new Infrastructure.Repository.OrderDal();

            var limitDateSpec = new LimitDateSpecification(new DateTime(2018,8,20));
            var citySpec = new CitySpecification("Paris");
            var res = query.Find(citySpec.And(limitDateSpec));

            // or
            var myOrder = new Domain.AggregateModels.Order(DateTime.Now, new Domain.AggregateModels.Address("rue de la liberté", "Paris"));
            bool isInCity = citySpec.IsSatisfiedBy(myOrder);

        }
    }
}
