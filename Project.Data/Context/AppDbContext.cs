using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // AppRole, AppUser tarzi siniflar Identity tarafindan saglandigi icin burada bir DbSet olarak vermek gerekmiyor.




        #region Address ilişkileri
        public DbSet<District> Districts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Address> Addresses { get; set; }
        #endregion


        #region Store ilişkileri
        public DbSet<Store> Stores{ get; set; }
        public DbSet<StoreImage> StoreImages { get; set; }
        public DbSet<StoreComment> StoreComments { get; set; }
        public DbSet<FavouriteStore> FavouriteStores { get; set; }

        public DbSet<LiveChat> LiveChats { get; set; }
        public DbSet<Message> Messages { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
