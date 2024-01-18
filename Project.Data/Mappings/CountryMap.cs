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
    public class CountryMap : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(
                new Country() { Id = Guid.Parse("6506BE3D-63B1-4707-8E20-1F01A2A63D86"), CountryCode = "TR", CountryName = "Türkiye", CreatedDate = new DateTime(2024, 1, 1), CreatedBy = "SYSTEM" }
                );
        }
    }
}
