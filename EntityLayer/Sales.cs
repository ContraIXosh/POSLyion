using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Sales
    {
        public int Sale_id { get; set; }
        public Users oUser { get; set; }
        public List<SaleDetails> oSaleDetails { get; set; }
        public Customers oCustomer { get; set; }
        public decimal Total { get; set; }
        public decimal Change { get; set; }
        public string Create_date { get; set; }
        public string Modify_date { get; set; }
    }
}
