using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Vendors
    {
        public int Vendor_id { get; set; }
        public string Cuit { get; set; }
        public string Company_name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool State { get; set; }
        public string Create_date { get; set; }
        public string Modify_date { get; set; }
    }
}
