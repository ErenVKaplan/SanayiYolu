using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.ViewModels.Stores
{
    public class StoreDetailsViewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public string StoreName { get; set; }
        public bool OnAir { get; set; }
        public string? StoreDescription { get; set; }
        public string? StoreSlogan { get; set; }
        public TimeSpan? OpeningTime { get; set; }
        public TimeSpan? ClosingTime { get; set; }
        public int? CrewSize { get; set; }

        public Address Address { get; set; }
    }
}
