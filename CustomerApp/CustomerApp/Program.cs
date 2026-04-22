/// <summary>
/// Create a program that gives gives information and store informations into classes 
/// Program : CustomerDetail.cs
/// Author : Jenny Trieu
/// Date : 04/22/2026
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomerApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Declare Varibles
            List<Customer> allcustomers;
            Customer customer; 
        }

        static Customer AddCustomer()
        {
            //Declare Varibles
            string firstname;
            string lastname;
            int ordercount;
            double totalsales;

            //Entering the prompt 
            firstname = Prompt("Enter your first name please : ");
            lastname = Prompt("Enter your last name please : ");
            ordercount = PromptInt("Enter the amount of orders : ");
            totalsales = PromptDouble("Enter the total sales : ");

            //Created new varible 
            Customer customer = new Customer(firstname, lastname, ordercount, totalsales);

            return customer;
        }

        static void DisplayCustomer(Customer customer)
        {
            //Provide feedback 
            Console.WriteLine($"Firstname: {customer.firstname}");
            Console.WriteLine($"Lastname: {customer.lastname}");
            Console.WriteLine($"Full Name: {customer.fullname}");
            Console.WriteLine($"OrderCount: {customer.ordercount}");
            Console.WriteLine($"TotalSales: {customer.totalsales}");
            Console.WriteLine($"AverageSales: {customer.AverageOrder}");
            Console.WriteLine($"Customer Tier: {customer.customerteir}");
        }

        static void DisplayAllCustomer(List<Customer> allcustomers)
        {
            //Foreach loop 
            foreach (Customer customer in allcustomers)
            {
                Console.WriteLine($"FullName: {customer.fullname}");
                Console.WriteLine($"TotalSales: {customer.totalsales}");
                Console.WriteLine($"OrderCount: {customer.ordercount}");
                Console.WriteLine();
            }
        }

        static Customer SearchCustomer(List<Customer> allcustomers)
        {
            string query = Prompt("Please enter the name you're looking for: ");
            List<Customer> selectedcustomers = new List<Customer>();
            Customer output = null;

            //loops
            foreach (Customer customer in allcustomers)
            {
                if (customer.firstname.Contains(query) || customer.lastname.Contains(query))
                {
                    selectedcustomers.Add(customer);
                }
            }

            if (selectedcustomers.Count == 0)
            {
                Console.WriteLine("No customers found!");
                Console.WriteLine("Returning first customer in list!");
                return allcustomers[0];
            }
            else if (selectedcustomers.Count == 1)
            {
                return selectedcustomers[0];
            }
            else
            {
                do
                {
                    query = Prompt("Please enter the customer full name in the following format (lastname, firstname) :  ").ToLower();

                    foreach (Customer customer in selectedcustomers)
                    {
                        if (customer.fullname.ToLower() == query) 
                        {
                            output = customer;
                        }
                    }

                    if (output == null)
                    {
                        Console.WriteLine("No customer found. Try again!");
                    }
                }
                while (output != null);

                return output;
            }
        }

       

        static string Prompt(string Message)
        {
            string output;
            Console.WriteLine(Message);
            output = Console.ReadLine();
            return output;
        }

        static double PromptDouble(string Message)
        {
            //Varible to store input
            double output = 0;

            //Loop that continues until non--sero value
            while (output == 0)

            {
                try
                {
                    //Display prompt message to user
                    Console.WriteLine(Message);

                    //Read output
                    output = double.Parse(Console.ReadLine());
                }
                catch
                {
                    //Display if parse fails
                    Console.WriteLine("Error");
                }

            }

            return output;

        }

        static int PromptInt(string Message)
        {
            //Varible to store input
            int output = 0;

            //Loop that continues until non--sero value
            while (output == 0)

            {
                try
                {
                    //Display prompt message to user
                    Console.WriteLine(Message);

                    //Read output
                    output = int.Parse(Console.ReadLine());
                }
                catch
                {
                    //Display if parse fails
                    Console.WriteLine("Error");
                }

            }

            return output;
        }
    }
}
