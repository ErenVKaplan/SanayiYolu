using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class FavouriteStore : EntityBase
    {
        public Guid StoreId { get; set; }
        public Guid UserId { get; set; }

        public Store Store { get; set; }
        public AppUser User { get; set; }
    }
}
