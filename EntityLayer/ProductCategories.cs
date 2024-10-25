using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ProductCategories
    {
        public int Product_category_id { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public int Quantity { get; set; }
        public string Create_date { get; set; }
        public string Modify_date { get; set; }
    }
}
