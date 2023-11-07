using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMS_Application.UI
{
    class AdminUI
    {

        public char adminMenu()
        {
            char op;
            Console.WriteLine("Press 1 to Add User");
            Console.WriteLine("Press 2 to Add a New item:");
            Console.WriteLine("Press 3 to Update an Exisitng item: ");
            Console.WriteLine("Press 4 to Delete an Exisitng item:");
            Console.WriteLine("Press 5 to Calculate Today's Sales:");
            Console.WriteLine("Press 6 to Exit: ");
            Console.Write("Enter Option: ");
            op = char.Parse(Console.ReadLine());
            return op;
        }



    }
}
