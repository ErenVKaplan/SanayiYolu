using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Store : EntityBase
    {
        public Guid UserId { get; set; }

        public string StoreName { get; set; }
        public bool OnAir {  get; set; } = false;

        //
        // bu degerler null olarak kayit olunacak. magaza panelinden dolduruldugunda Store aktif olacak.
        public string? StoreDescription { get; set; }
        public string? StoreSlogan { get; set; }
        public TimeSpan? OpeningTime { get; set; }
        public TimeSpan? ClosingTime { get; set; }
        public int? CrewSize { get; set; }
        //
        //


        public AppUser User { get; set; }
        public Address Address { get; set; }
        public ICollection<StoreImage> Images { get; set; } = new HashSet<StoreImage>();
        public ICollection<StoreComment> Comments { get; set; } = new HashSet<StoreComment>();
        public ICollection<FavouriteStore> FavouriteStores { get; set; } = new HashSet<FavouriteStore>();

        public ICollection<LiveChat> LiveChats { get; set; } = new HashSet<LiveChat>();
    }
}
