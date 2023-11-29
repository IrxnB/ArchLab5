using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchLab5.DTO
{
    public class UserDetails
    {
        public long id { get; set; }
        public string bdate { get; set; }
        public Place city { get; set; }
        public Place country { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set;}

        public string Name { get => first_name + " " + last_name; }
    }
}
