using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class StoreComment : EntityBase
    {
        public Guid StoreId { get; set; }
        public Guid UserId { get; set; }

        public int Score { get; set; }
        public string MessageContent { get; set; }

        public Store Store { get; set; }
        public AppUser User { get; set; }
    }
}
