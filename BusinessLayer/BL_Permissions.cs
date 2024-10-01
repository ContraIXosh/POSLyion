using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Permissions
    {
        private DL_Permissions oPermission = new DL_Permissions();

        public List<Permissions> Read(int user_id)
        {
            return oPermission.Read(user_id);
        }
    }
}
