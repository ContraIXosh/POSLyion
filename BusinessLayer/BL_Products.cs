using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Products
    {
        private DL_Products oProduct = new DL_Products();

        public int Create(Products product, out string message)
        {
            message = string.Empty;
            if (product.Bar_code == "")
            {
                message += "Es necesario el código de barras.\n";
            }
            if (product.Description == "")
            {
                message += "Es necesario la descripción del producto.\n";
            }
            if (product.Cost_price == 0)
            {
                message += "Es necesario el costo del producto.\n";
            }
            if (product.Sale_price == 0)
            {
                message += "Es necesario el precio de venta del producto.\n";
            }
            if (message != string.Empty)
            {
                return 0;
            }
            else
            {
                return oProduct.Create(product, out message);
            }
        }

        public List<Products> ListAll()
        {
            return oProduct.Read();
        }

        public bool Update(Products product, out string message)
        {
            message = string.Empty;
            if (product.Bar_code == "")
            {
                message += "Es necesario el código de barras.\n";
            }
            if (product.Description == "")
            {
                message += "Es necesario la descripción del producto.\n";
            }
            if (product.Cost_price == 0)
            {
                message += "Es necesario el costo del producto.\n";
            }
            if (product.Sale_price == 0)
            {
                message += "Es necesario el precio de venta del producto.\n";
            }
            if (message != string.Empty)
            {
                return false;
            }
            else
            {
                return oProduct.Update(product, out message);
            }
        }

        public bool Delete(Products product, out string message)
        {
            return oProduct.Delete(product, out message);
        }

        public bool Restore(Products product, out string message)
        {
            return oProduct.Restore(product, out message);
        }
    }
}
