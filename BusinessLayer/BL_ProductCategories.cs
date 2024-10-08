using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_ProductCategories
    {

        private DL_ProductCategories oProductCategory = new DL_ProductCategories();

        public int Create(ProductCategories productcategory, out string message)
        {
            message = string.Empty;
            if (productcategory.Description == "")
            {
                message += "Es necesario la descripción de la categoría.\n";
            }
            if (message != string.Empty)
            {
                return 0;
            }
            else
            {
                return oProductCategory.Create(productcategory, out message);
            }
        }

        public List<ProductCategories> ListAll()
        {
            return oProductCategory.Read();
        }

        public bool Update(ProductCategories productcategory, out string message)
        {
            message = string.Empty;
            if (productcategory.Description == "")
            {
                message += "Es necesario la descripción de la categoría.\n";
            }
            if (message != string.Empty)
            {
                return false;
            }
            else
            {
                return oProductCategory.Update(productcategory, out message);
            }
        }

        public List<ProductCategories> CountProducts()
        {
            return oProductCategory.CountProducts();
        }

        public bool Delete(ProductCategories productcategory, out string message)
        {
            return oProductCategory.Delete(productcategory, out message);
        }

        public bool Restore(ProductCategories productcategory, out string message)
        {
            return oProductCategory.Restore(productcategory, out message);
        }
    }
}
