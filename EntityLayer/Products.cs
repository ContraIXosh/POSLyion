using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Products
    {
        public string Product_id { get; set; }
        public string Bar_code { get; set; }
        public string Description { get; set; }
        public ProductCategories oProductCategory { get; set; }
        public decimal Cost_price { get; set; }
        public decimal Sale_price { get; set; }
        public int Current_stock { get; set; }
        public int Minimum_stock { get; set; }
        public bool State { get; set; }
        public string Create_date { get; set; }
        public string Modify_date { get; set; }
    }
}
