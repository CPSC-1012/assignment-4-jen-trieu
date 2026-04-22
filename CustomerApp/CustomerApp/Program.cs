/// <summary>
///  Create a program that gives gives information and store informations into classes 
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
            string firstname;
            string lastname;
            int ordercount;
            double totalsales;



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
