using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PaymentWay
{
    public class PaymentWayEntityConfiguration : IEntityTypeConfiguration<PaymentWay>
    {
        public void Configure(EntityTypeBuilder<PaymentWay> builder)
        {
            builder.ToTable("Order");
            
        }
    }
}
