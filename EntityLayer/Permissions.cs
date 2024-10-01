using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Permissions
    {
        public int Permission_id { get; set; }
        public Roles oRol { get; set; }
        public string Menu_name { get; set; }
        public string Create_date { get; set; }
    }
}
