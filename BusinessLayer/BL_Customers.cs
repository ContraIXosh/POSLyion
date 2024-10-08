using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Customers
    {
        private DL_Customers oCustomer = new DL_Customers();

        public int Create(Customers customer, out string message)
        {
            message = string.Empty;
            if (customer.Full_name == "")
            {
                message += "Es necesario el nombre completo de pila.\n";
            }
            if (message != string.Empty)
            {
                return 0;
            }
            else
            {
                return oCustomer.Create(customer, out message);
            }
        }

        public List<Customers> ListAll()
        {
            return oCustomer.Read();
        }

        public bool Update(Customers customer, out string message)
        {
            message = string.Empty;
            if (customer.Full_name == "")
            {
                message += "Es necesario el nombre completo de pila.\n";
            }
            if (message != string.Empty)
            {
                return false;
            }
            else
            {
                return oCustomer.Update(customer, out message);
            }
        }

        public bool Delete(Customers customer, out string message)
        {
            return oCustomer.Delete(customer, out message);
        }

        public bool Restore(Customers customer, out string message)
        {
            return oCustomer.Restore(customer, out message);
        }
    }
}
