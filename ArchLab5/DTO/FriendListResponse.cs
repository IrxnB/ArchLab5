using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchLab5
{
    public class FriendListResponse
    {
        public long count { get; set; }
        public List<FriendListItem> items { get; set; }
    }
}
