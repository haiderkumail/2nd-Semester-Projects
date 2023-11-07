
using DSMS_Application.BL;
using DSMS_Application.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMS_Application.DL
{
    class AdminDL : AdminUI
    {
        public static List<Admin> users = new List<Admin>();
        public static List<Admin> admin = new List<Admin>();
        public static List<product> product = new List<product>();
        public void adminFunctions()
        {
            SignupUI s = new SignupUI();
            AdminUI s1 = new AdminUI();
            AdminDL s2 = new AdminDL();


            string path1 = "newUsers.txt";
            string path2 = "productsinfo.txt";

            int adminChoice;
            do
            {
                Console.Clear();
                adminChoice = adminMenu();
                Console.ReadLine();

                if (adminChoice == '1')
                {
                    Console.Clear();
                    loadNewUserData(path1, users);
                    addUser(users);
                    saveNewUserData(path1, users);
                }
                else if (adminChoice == '2')
                {
                    Console.Clear();
                    addItem(path2, product);
                    saveProductData(path2, product);
                }
                else if (adminChoice == '3')
                {
                    Console.Clear();
                    s2.viewProducts(path2, product);
                    updateItem(path2, product);
                    saveProductData(path2, product);
                }
                else if (adminChoice == '4')
                {
                    Console.Clear();
                    s2.viewProducts(path2, product);
                    s2.deleteItem(path2, product);
                }

                else if (adminChoice == '5')
                {
                    Console.Clear();
                    double result = OverallSale(product, admin);
                    Console.WriteLine("The OverAll Sale Is :" + result);
                    string option;
                    Console.WriteLine("Press 0 to go back");
                    option = Console.ReadLine();
                    if (option == "0")
                    {
                        adminFunctions();
                    }
                }

            } while (adminChoice != '6');

        }

        public void loadNewUserData(string path1, List<Admin> users)
        {
            bool check = readNewUserData(path1, users);
            if (check)
                Console.WriteLine("Data Loaded SuccessFully");
            else
                Console.WriteLine("Data Not Loaded");
            Console.ReadKey();
        }
        public void addUser(List<Admin> users)
        {

            string option = "1";
            while (option != "0")
            {
                Admin u = new Admin();
                Console.Clear();
                Console.Write("Enter Name: ");
                u.name = Console.ReadLine();
                Console.Write("Enter Password: ");
                u.password = Console.ReadLine();
                Console.Write("Enter Role: ");
                u.role = Console.ReadLine();
                users.Add(u);
                Console.Write("User added successfully !! ");
                Console.WriteLine("Press 0 to go back");
                option = Console.ReadLine();
                if (option == "0")
                {
                    break;
                }
            }
        }
        public void addItem(string path2, List<product> product)
        {
            string check = "1";

            while (check != "0")
            {
                Console.Clear();
                product s = new product();
                Console.WriteLine("enter product name: ");
                s.productName = Console.ReadLine();
                Console.WriteLine("enter product price: ");
                s.price = Console.ReadLine();
                Console.WriteLine("enter product quantity: ");
                s.quantity = Console.ReadLine();
                product.Add(s);
                Console.WriteLine(" ");
                Console.WriteLine("product added successfully");
                Console.WriteLine(" ");
                Console.WriteLine("Press 0 to go back");
                check = Console.ReadLine();
                if (check == "0")
                {
                    break;
                }

            }
        }
        public bool readNewUserData(string path1, List<Admin> users)
        {
            string record;
            if (File.Exists(path1))
            {
                StreamReader fp = new StreamReader(path1);
                while ((record = fp.ReadLine()) != null)
                {
                    string name = parseData(record, 1);
                    string password = parseData(record, 2);
                    string role = parseData(record, 3);
                    string email=parseData(record, 4);
                    string address = parseData(record, 5);
                    Admin user = new Admin(name, password, role,email,address);
                    storeDataInList(users, user);
                }
                fp.Close();
                return true;
            }
            return false;

        }
        public void storeDataInList(List<Admin> users, Admin user)
        {
            users.Add(user);
        }
        public string parseData(string record, int field)
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

        public void saveNewUserData(string path1, List<Admin> users)
        {
            StreamWriter f2 = new StreamWriter(path1, true);
            for (int x = 0; x < users.Count(); x++)
            {
                f2.WriteLine(users[x].name + "," + users[x].password + "," + users[x].role);
            }
            f2.Flush();
            f2.Close();
        }
        public void viewProducts(string path2, List<product> product)
        {
            Console.Clear();
            Console.WriteLine("Product\t\tPrice\t\tQuantity");
            for (int x = 0; x < product.Count(); x++)
            {
                Console.WriteLine(product[x].productName + "\t\t" + product[x].price + "\t\t" + product[x].quantity);
            }

        }
        public void saveProductData(string path2, List<product> product)
        {
            StreamWriter f1 = new StreamWriter(path2, true);
            for (int x = 0; x < product.Count(); x++)
            {
                f1.WriteLine(product[x].productName + "," + product[x].price + "," + product[x].quantity);
            }
            f1.Flush();
            f1.Close();
        }
        public bool readProductData(string path2, List<Admin> product)
        {
            string record;
            if (File.Exists(path2))
            {
                StreamReader fp = new StreamReader(path2);
                while ((record = fp.ReadLine()) != null)
                {
                    string productName = parseData(record, 1);
                    string price = parseData(record, 2);
                    string quantity = parseData(record, 3);
                    product products = new product(productName, price, quantity);
                    storeProductDataInList(product, products);
                }
                fp.Close();
                return true;
            }
            return false;
        }

        private void storeProductDataInList(List<Admin> product, product products)
        {
            throw new NotImplementedException();
        }

        private void storeProductDataInList(List<Admin> product, Admin products)
        {
            product.Add(products);
        }
        public void updateItem(string path2, List<product> product)
        {
            product d = new product();
            bool flag = false;
            string option = "1";
            while (option != "0")
            {
                Console.WriteLine("Enter Product Name you want to Update: ");
                d.productName = Console.ReadLine();
                Console.WriteLine("Enter the Updated price");
                d.price = Console.ReadLine();
                Console.WriteLine("Enter the Updated Quantity: ");
                d.quantity = Console.ReadLine();
                for (int i = 0; i < product.Count(); i++)
                {
                    if (product[i].productName == d.productName || product[i].price == d.price || product[i].quantity == d.quantity)
                    {
                        product[i].productName = d.productName;
                        product[i].price = d.price;
                        product[i].quantity = d.quantity;
                        Console.ReadLine();
                        flag = true;
                    }
                    if (flag == true)
                        Console.WriteLine("product price and quantity are updated ");
                    if (flag == false)
                        Console.WriteLine("product not found");
                }

                Console.WriteLine("Press 0 to go back");
                option = Console.ReadLine();
                if (option == "0")
                {
                    break;
                }

            }

        }
        public void deleteItem(string path2, List<product> products)
        {
            string product;
            string quantity;
            string price;
            bool check = false;
            string option = "1";
            while (option != "0")
            {
                Console.WriteLine(" Enter product name: ");
                product = Console.ReadLine();
                Console.WriteLine(" Enter Quantity: ");
                quantity = Console.ReadLine();
                Console.WriteLine(" Enter Price: ");
                price = Console.ReadLine();
                for (int i = 0; i < products.Count(); i++)
                {
                    if (products[i].productName == product && products[i].quantity == quantity && products[i].price == price)
                    {
                        products.RemoveAt(i);
                        check = true;
                    }
                }
                if (check == true)
                {
                    Console.WriteLine("...............product removed Successfully");
                }
                else if (check == false)
                {
                    Console.WriteLine("...............product not found");
                }
                Console.WriteLine(" Enter 0 to go back......... ");
                option = (Console.ReadLine());
                if (option == "0")
                {
                    break;
                }
            }

        }


        public double OverallSale(List<product> product, List<Admin> admin)
        {
            double totalSales = 0.0;
            foreach (var item in product)
            {
                string productName = item.productName;
                double quantity = double.Parse(item.quantity);
                double price = double.Parse(item.price);
                Admin s = new Admin();
                if (item.productName == productName)
                {
                    
                    double sales = (price) * (quantity);
                    for (int i = 0; i < product.Count(); i++)
                    {
                        s.totalSales += sales;
                        admin.Add(s);
                    }
                }
                else
                {
                    Console.WriteLine($"Product '{productName}' does not exist in the store.");
                }
            }

            return totalSales;

        }

        internal void AddUser(AddUser addUser)
        {
            throw new NotImplementedException();
        }
    }
}
