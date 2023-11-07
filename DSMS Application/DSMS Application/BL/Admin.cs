using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DSMS_Application.UI;
using DSMS_Application.DL;

namespace DSMS_Application.BL
{
    public class Admin
    {
        public string name { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public double totalSales;
        public string email { get; set; }
        public string address { get; set; }

        AdminUI s = new AdminUI();

        public Admin()
        {
        }

        public Admin(string name, string password, string role, string email, string address)
        {
            this.name = name;
            this.password = password;
            this.role = role;
            this.email = email;
            this.address = address;
        }

       
    }
    public class product
    {
        public string productName { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }

        public product(string productName, string quantity, string price)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;
        }

        public product()
        {
        }
    }
}
