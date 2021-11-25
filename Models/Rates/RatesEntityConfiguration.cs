using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Rates
{
    public class RatesEntityConfiguration : IEntityTypeConfiguration<Rates>
    {
        public void Configure(EntityTypeBuilder<Rates> builder)
        {
            throw new NotImplementedException();
        }
    }
}
