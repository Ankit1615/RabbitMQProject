using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //demo s = new demo();
            //s.hasTableQue();
            //customer cus = new customer();
            //cus.AddCustomer("Ankit");
            //cus.AddCustomer("yadav");
            //cus.DisplayCustomer();

            //Console.WriteLine(cus[0]);

            customerdetails cus = new customerdetails() ;
            
            cus.Display();
            Console.Read();
        }
    }
}
