using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMS_Application.BL
{
   
    public class Signup
    {
        public string name;
        public string password;
        public string role;

        public Signup()
        {
        }

        public Signup(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public Signup(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public bool isAdmin()
        {
            if (role == "Admin" || role == "admin")
            {
                return true;
            }
            return false;

        }


    }
}
