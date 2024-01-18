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
    public class LiveChatMap : IEntityTypeConfiguration<LiveChat>
    {
        public void Configure(EntityTypeBuilder<LiveChat> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(fs => fs.User).WithMany(au => au.LiveChats).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(fs => fs.Store).WithMany(s => s.LiveChats).HasForeignKey(fs => fs.StoreId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
