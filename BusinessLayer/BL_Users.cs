using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BL_Users
    {
        private DL_Users oUser = new DL_Users();

        public int Create(Users user, out string message)
        {
            message = string.Empty;
            if (user.Full_name == "")
            {
                message += "Es necesario el nombre completo de pila.\n";
            }
            if (user.Username == "")
            {
                message += "Es necesario el nombre de usuario.\n";
            }
            if (user.Password == "")
            {
                message += "Es necesario la contraseña del usuario.\n";
            }
            if (message != string.Empty)
            {
                return 0;
            }
            else
            {
                return oUser.Create(user, out message);
            }
        }

        public List<Users> ListAll()
        {
            return oUser.Read();
        }

        public bool Update(Users user, out string message)
        {
            message = string.Empty;
            if (user.Full_name == "")
            {
                message += "Es necesario el nombre completo de pila.\n";
            }
            if (user.Username == "")
            {
                message += "Es necesario el nombre de usuario.\n";
            }
            if (user.Password == "")
            {
                message += "Es necesario la contraseña del usuario.\n";
            }
            if (message != string.Empty)
            {
                return false;
            }
            else
            {
                return oUser.Update(user, out message);
            }
        }

        public bool Delete(Users user, out string message)
        {
            return oUser.Delete(user, out message);
        }

        public bool Restore(Users user, out string message)
        {
            return oUser.Restore(user, out message);
        }
    }
}
