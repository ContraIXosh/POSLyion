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

        public List<Users> ListAll()
        {
            return oUser.ListAll();
        }
    }
}
