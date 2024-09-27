using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;

namespace BusinessLayer
{
    public class BL_Roles
    {

        private DL_Roles oRol = new DL_Roles();

        public List<Roles> ListAll()
        {
            return oRol.ListAll();
        }
    }
}
