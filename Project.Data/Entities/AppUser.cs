using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Store Store { get; set; }
        public ICollection<LiveChat> LiveChats { get; set; } = new HashSet<LiveChat>();
        public ICollection<StoreComment> Comments { get; set; } = new HashSet<StoreComment>();
        public ICollection<FavouriteStore> Favorites { get; set; } = new HashSet<FavouriteStore>();

    }
}
