using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.ViewModels.StoreComments
{
    public class StoreCommentCreateViewModel
    {
        public Guid StoreId { get; set; }
        public int Score { get; set; }
        public string MessageContent { get; set; }
    }
}
