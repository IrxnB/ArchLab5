using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchLab5
{
    public class FriendListItem
    {
        public long id { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }

        public string? name { get => first_name + " " + last_name; }
    }
}
