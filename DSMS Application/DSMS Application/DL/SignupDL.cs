using DSMS_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSMS_Application.UI;

namespace DSMS_Application.DL
{
    class SignupDL:SignupUI
    {
       public static List<Signup> users = new List<Signup>();

        AdminDL u1 = new AdminDL();
        CustomerDL c = new CustomerDL();



        string path = "textfile.txt";
        private int option;
        public void Menu()
        {
            bool check = readData(path, users);
            do
            {
                if (option == 1)
                {
                    Signup user = takeInputWithoutRole();
                    if (user != null)
                    {
                        user = signIn(user, users);
                        if (user == null)
                        {
                            Console.WriteLine("Invalid User");
                            Console.WriteLine("Press any key to continue......");
                            Console.ReadKey();
                        }

                        else if (user.isAdmin())
                        {
                            Console.WriteLine("Admin Menu");
                            Console.WriteLine("Press any key to continue......");
                            Console.ReadKey();
                            Console.Clear();
                            u1.adminFunctions();
                        }
                        else
                        {
                            Console.WriteLine("Customer Menu");
                            Console.WriteLine("Press any key to continue......");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
                else if (option == 2)
                {
                    Signup user = takeInputWithRole();
                    if (user != null)
                    {
                        storeDataInFile(path, user);
                        storeDataInList(users, user);

                    }
                }
            }
            while (option != 3);
        }

        public Signup signIn(Signup user, List<Signup> users)
        {
            foreach (Signup storedUser in users)
            {
                if (user.name == storedUser.name && user.password == storedUser.password)
                {
                    return storedUser;

                }
            }
            return null;
        }
        public void storeDataInList(List<Signup> users, Signup user)
        {
            users.Add(user);
        }

        public void storeDataInFile(string path, Signup user)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.name + "," + user.password + "," + user.role);
            file.Flush();
            file.Close();
        }

        public bool readData(string path, List<Signup> users)

        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string name = parseData(record, 1);
                    string password = parseData(record, 2);
                    string role = parseData(record, 3);
                    Signup user = new Signup(name, password, role);
                    storeDataInList(users, user);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
    }
}
