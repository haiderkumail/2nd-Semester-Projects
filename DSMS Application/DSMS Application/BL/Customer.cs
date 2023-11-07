using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMS_Application.BL
{
    class Customer
    {
        public string productName;
        public float price;
        public float quantity;
        public string productType;

        public Customer()
        {
        }

        public Customer(string productName, float quantity, float price)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;
        }




    }
}
