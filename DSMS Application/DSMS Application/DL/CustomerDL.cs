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
    class CustomerDL
    {
        public void customerFunctions()
        {

            List<Customer> customerList = new List<Customer>();
            List<Customer> productList = new List<Customer>();


            string path3 = "customerproductsinfo.txt";

            CustomerUI s = new CustomerUI();

            int customerChoice;
            do
            {
                Console.Clear();
                customerChoice = s.customerMenu();
                Console.ReadLine();

                if (customerChoice == 1)
                {
                    Console.Clear();
                    callbuyProduct(productList, s);
                    saveCustomerProductData(path3, productList);

                }
                else if (customerChoice == 2)
                {
                    Console.Clear();
                    viewProducts(productList);
                    Console.ReadKey();

                }
                else if (customerChoice == 3)
                {
                    Console.Clear();
                    viewProducts(productList);
                    updateItem(productList);
                    saveCustomerProductData(path3, productList);
                }
                else if (customerChoice == 4)
                {
                    Console.Clear();
                    viewProducts(productList);
                    deleteItem(productList);
                }

            } while (customerChoice != 5);
        }

        public void callbuyProduct(List<Customer> productList, CustomerUI s)
        {
            Customer c = new Customer();
            Console.Write("enter the no of products you want to buy: ");
            int option = int.Parse(Console.ReadLine());
            for (int i = 0; i < option; i++)
            {
                Console.Write("Enter the product name: ");
                c.productName = Console.ReadLine();
                Console.Write("Enter the product Quantity: ");
                c.quantity = float.Parse(Console.ReadLine());
                Console.Write("Enter the product Type: ");
                c.productType = Console.ReadLine();
            }
            Console.WriteLine(" ");
            Console.WriteLine("product added successfully");
            Console.WriteLine(" ");
            if (c.productType == "grocery")
            {
                c.price = c.quantity * 200;
                Console.WriteLine("Your bill Is :" + c.price);
            }
            if (c.productType == "fruit" || c.productType == "vegetable")
            {
                c.price = c.quantity * 100;
                Console.WriteLine("Your bill Is :" + c.price);
            }
            if (c.productType != "grocery" && (c.productType != "fruit" || c.productType != "vegetable"))
            {
                c.price = c.quantity * 50;
                Console.WriteLine("Your bill Is :" + c.price);
            }
            productList.Add(c);
            Console.WriteLine("Press 0 to go back");
            string check = Console.ReadLine();
            if (check == "0")
            {
                Console.Clear();
                s.customerMenu();
            }

        }
        public void saveCustomerProductData(string path3, List<Customer> productList)
        {
            StreamWriter f1 = new StreamWriter(path3, true);
            for (int x = 0; x < productList.Count(); x++)
            {
                f1.WriteLine(productList[x].productName + "," + productList[x].price + "," + productList[x].quantity);
            }
            f1.Flush();
            f1.Close();
        }
        public bool readCustomerProductData(string path3, List<Customer> productList)
        {
            string record;
            if (File.Exists(path3))
            {
                StreamReader fp = new StreamReader(path3);
                while ((record = fp.ReadLine()) != null)
                {
                    string productName = parseData(record, 1);
                    float price = float.Parse(parseData(record, 2));
                    float quantity = float.Parse(parseData(record, 3));
                    Customer products = new Customer(productName, price, quantity);
                    storeCustomerProductDataInList(productList, products);
                }
                fp.Close();
                return true;
            }
            return false;
        }
        private void storeCustomerProductDataInList(List<Customer> productList, Customer products)
        {
            productList.Add(products);
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
        public void viewProducts(List<Customer> productList)
        {
            Console.Clear();
            Console.WriteLine("Product\t\tPrice\t\tQuantity");
            for (int x = 0; x < productList.Count(); x++)
            {
                Console.WriteLine(productList[x].productName + "\t\t" + productList[x].price + "\t\t" + productList[x].quantity);
            }

        }
        public void updateItem(List<Customer> productList)
        {
            Customer d = new Customer();
            bool flag = false;
            string option = "1";
            while (option != "0")
            {
                Console.WriteLine("Enter Product Name you want to Update: ");
                d.productName = Console.ReadLine();
                Console.WriteLine("Enter the Updated price");
                d.price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Updated Quantity: ");
                d.quantity = int.Parse(Console.ReadLine());
                for (int i = 0; i < productList.Count(); i++)
                {
                    if (productList[i].productName == d.productName || productList[i].price == d.price || productList[i].quantity == d.quantity)
                    {
                        productList[i].productName = d.productName;
                        productList[i].price = d.price;
                        productList[i].quantity = d.quantity;
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
        public void deleteItem(List<Customer> productList)
        {
            string product;
            int quantity;
            int price;
            bool check = false;
            string option = "1";
            while (option != "0")
            {
                Console.WriteLine(" Enter product name: ");
                product = Console.ReadLine();
                Console.WriteLine(" Enter Quantity: ");
                quantity = int.Parse(Console.ReadLine());
                Console.WriteLine(" Enter Price: ");
                price = int.Parse(Console.ReadLine());
                for (int i = 0; i < productList.Count(); i++)
                {
                    if (productList[i].productName == product && productList[i].quantity == quantity && productList[i].price == price)
                    {
                        productList.RemoveAt(i);
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
    }
}
