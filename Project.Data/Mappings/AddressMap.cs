using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Mappings
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);

            // Address - Country    1 to n
            builder.HasOne(a => a.Country).WithMany(c => c.Addresses).HasForeignKey(a => a.CountryId).IsRequired().OnDelete(DeleteBehavior.NoAction);

            // Address - City    1 to n
            builder.HasOne(a => a.City).WithMany(c => c.Addresses).HasForeignKey(a => a.CityId).IsRequired().OnDelete(DeleteBehavior.NoAction);

            // Address - District   1 to n
            builder.HasOne(a => a.District).WithMany(c => c.Addresses).HasForeignKey(a => a.DistrictId).IsRequired().OnDelete(DeleteBehavior.NoAction);

        }
    }
}
