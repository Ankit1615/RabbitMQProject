using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class assignmentDay1
    {
        public static void greatestno()
        {
            int a = 10;
            int b = 20;
            int c = 30;
            Console.WriteLine(a > b ? (a > c ? a : c) : (b > c ? b : c));

        }

        public static void empdetails()
        {
            Console.WriteLine("Please enter your name : ");
            Console.ReadLine();
            Console.WriteLine("Please enter your basic : ");
            double basic = double.Parse(Console.ReadLine());
            double hra = .15 * basic;
            Console.WriteLine("Your HRA will be: {0}", hra);
            double da = .10 * basic;
            Console.WriteLine("DA will be : {0}", da);
            double tax = .08 * basic;
            Console.WriteLine("TAX will be : {0}", tax);
            Console.WriteLine("Your grosspay = {0}", da + basic + hra);

        }

        public static int factorial(int a)
        {
            if (a == 1)
                return 1;
            else
                return a * factorial(a - 1);
        }

        public static int sumofnum()
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum = sum + a;
            }
            return sum;
        }

        public static void sumofnums()
        {
            //Console.ReadLine("Please enter a number")
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < 0)
                {
                    Console.WriteLine("Warning you have enter negative number!");
                    break;
                }
                else
                    sum = sum + a;
            }
        }

        public static void swapnums()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c;
            c = a;
            a = b;
            b = c;

            Console.WriteLine("{0} and {1}", a, b);
        }
        public static void swapnumswithouttemp()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            a = b + a;
            b = a - b;
            a = b - a;

            Console.WriteLine("{0} and {1}", a, b);
        }

        public static void newstring()
        {
            Console.WriteLine("Enter First string");
            string a = Console.ReadLine();
            Console.WriteLine("Enter Second string");
            string b = Console.ReadLine();
            string c = a + b;
            Console.WriteLine(c);
        }

        public static void remainderwala()
        {
            int a = 21;
            int b = 8;
            int r = a / b;
            int q = a % b;

            Console.WriteLine("{0} is the remainder and {1} is the quotient", r, q);
        }

        public static void sqaureroot()
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(a));

        }

        public static void decimals()
        {
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(a));

        }

    }
}
