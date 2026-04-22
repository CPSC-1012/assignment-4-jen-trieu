/// <summary>
///  Create a program that gives gives information and store informations into classes 
/// Program : CustomerDetail.cs
/// Author : Jenny Trieu
/// Date : 04/22/2026
/// </summary>
using System;


public class Customer
{
    double _totalSales = 0;
    int _ordercount = 0;

    //Declaring Varibles 
    public string firstname { get; set; }
    public string lastname { get; set; }
    public int ordercount
    {
        //Declaring Value
        get { return _ordercount; }
        set
        {
            //If and else
            if (value <= 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                _ordercount = value;
            }
        }
    }
    public double totalsales
    {
        //Declaring Value
        get { return _totalSales; }
        set
        {
            //If and else 
            if (value < 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                _totalSales = value;
            }
        }
    }
    public double AverageOrder
    {
        get
        {
            return totalsales / ordercount;

        }
    }
    public string customerteir
    {
        get
        {
            // IF and Else 
            if (ordercount < 10)
            {

                return "Bronze";


            }
            else if (ordercount > 49)
            {

                return "Gold";


            }
            else

            { return "Silver"; }
        }

    }

    public string fullname
    {
        get
        {
            return $"{lastname}, {firstname}";
        }
    }

    public Customer(string first, string last, int count, double total)
    {
        //Constructor
        firstname = first;
        lastname = last;
        ordercount = count;
        totalsales = total;

    }
}
