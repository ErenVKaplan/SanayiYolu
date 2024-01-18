using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Message : EntityBase
    {
        public Guid LiveChatId { get; set; }
        public Guid SenderId { get; set; }
        public string MessageContent { get; set; }
        
        public LiveChat LiveChat { get; set; }
        public AppUser Sender {  get; set; }
    }
}
