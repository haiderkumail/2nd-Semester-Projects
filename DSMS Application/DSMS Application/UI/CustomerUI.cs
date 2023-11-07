using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMS_Application.UI
{
    class CustomerUI
    {
        public int customerMenu()
        {
            int op;
            Console.WriteLine("Press 1 to Buy Products:");
            Console.WriteLine("Press 2 to View Products:");
            Console.WriteLine("Press 3 to Update an Exisitng product: ");
            Console.WriteLine("Press 4 to Delete an Exisitng product:");
            Console.WriteLine("Press 5 to Exit: ");
            Console.Write("Enter Option: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}
