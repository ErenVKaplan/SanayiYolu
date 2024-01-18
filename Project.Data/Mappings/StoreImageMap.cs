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
    public class StoreImageMap : IEntityTypeConfiguration<StoreImage>
    {
        public void Configure(EntityTypeBuilder<StoreImage> builder)
        {
            // composite primary key
            builder.HasKey(pi => pi.Id);

            // StoreImage - Store   1 to n
            builder.HasOne(pi => pi.Store).WithMany(p => p.Images).HasForeignKey(pi => pi.StoreId).OnDelete(DeleteBehavior.Cascade);

            // StoreImage - Image     1 to n
            builder.HasOne(pi => pi.Image).WithMany(i => i.StoreImages).HasForeignKey(pi => pi.ImageId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
