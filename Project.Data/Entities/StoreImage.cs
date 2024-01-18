using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class StoreImage : EntityBase
    {
        public Guid StoreId { get; set; }
        public Guid ImageId { get; set; }

        public Store Store { get; set; }
        public Image Image { get; set; }
    }
}
