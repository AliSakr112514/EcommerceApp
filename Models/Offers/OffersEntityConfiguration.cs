using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Offers
{
    class OffersEntityConfiguration : IEntityTypeConfiguration<Offers>
    {
        public void Configure(EntityTypeBuilder<Offers> builder)
        {
            throw new NotImplementedException();
        }
    }
}
