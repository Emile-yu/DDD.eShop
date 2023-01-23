using DDD.Demo.eShop.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.eShop.Domain.Models
{
    public class Address : ValueObject
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }

        public Address()
        {

        }
        public Address(string street, string city, string country, string zipCode)
        {
            Street = street;
            City = city;
            Country = country;
            ZipCode = zipCode;
        }

        public override IEnumerable<object> EqualsCore()
        {
            yield return Street;
            yield return City;
            yield return Country;
            yield return ZipCode;
        }

        public override int GetHashCodeCore()
        {
            return (Street, City, Country, ZipCode).GetHashCode();
        }
    }
}
