using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Vendors
    {
        private DL_Vendors oVendor = new DL_Vendors();

        public int Create(Vendors vendor, out string message)
        {
            message = string.Empty;
            if (vendor.Company_name == "")
            {
                message += "Es necesario el nombre de la empresa o proveedor.\n";
            }
            if (message != string.Empty)
            {
                return 0;
            }
            else
            {
                return oVendor.Create(vendor, out message);
            }
        }

        public List<Vendors> ListAll()
        {
            return oVendor.Read();
        }

        public bool Update(Vendors vendor, out string message)
        {
            message = string.Empty;
            if (vendor.Company_name == "")
            {
                message += "Es necesario el nombre de la empresa o proveedor.\n";
            }
            if (message != string.Empty)
            {
                return false;
            }
            else
            {
                return oVendor.Update(vendor, out message);
            }
        }

        public bool Delete(Vendors vendor, out string message)
        {
            return oVendor.Delete(vendor, out message);
        }

        public bool Restore(Vendors vendor, out string message)
        {
            return oVendor.Restore(vendor, out message);
        }
    }
}
