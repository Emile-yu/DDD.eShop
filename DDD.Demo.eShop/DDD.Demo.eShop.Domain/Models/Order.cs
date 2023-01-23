using DDD.Demo.eShop.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.eShop.Domain.Models
{
    public class Order : Entity
    {
        public DateTime OrderDate { get; private set; }

        public string Status { get; private set; }

        public Address Address { get; private set; }

        public Order()
        {

        }

        public Order(DateTime orderDate, string status, Address address)
        {
            OrderDate = orderDate;
            Status = status;
            Address = address;
        }
    }
}
