using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Users
    {
        public int User_id { get; set; }
        public string Dni { get; set; }
        public string Full_name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Roles oRol { get; set; }
        public bool State { get; set; }
        public string Create_date { get; set; }
        public string Modify_date { get; set; }
    }
}
