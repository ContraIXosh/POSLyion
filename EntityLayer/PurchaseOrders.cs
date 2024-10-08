using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class PurchaseOrders
    {
        public int Purchase_order_id { get; set; }
        public Users oUser { get; set; }
        public Vendors oVendor { get; set; }
        public List<PurchaseOrderDetails> oPurchaseOrderDetails { get; set; }
        public decimal Total { get; set; }
        public string Document_type { get; set; }
        public string Document_number { get; set; }
        public string Document_date { get; set; }
        public string Create_date { get; set; }
    }
}
