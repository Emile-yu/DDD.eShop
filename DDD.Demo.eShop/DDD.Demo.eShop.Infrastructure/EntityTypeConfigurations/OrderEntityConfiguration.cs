using DDD.Demo.eShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.eShop.Infrastructure.EntityTypeConfigurations
{
    public class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.Id);

            builder.Property(o => o.OrderDate);

            builder.Property(o => o.Status);

            builder.OwnsOne(o => o.Address);
        }
    }
}
