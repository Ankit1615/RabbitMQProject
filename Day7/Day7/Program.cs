using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EFdemo ob=new EFdemo();
            //ob.diplaycustomer();
            //ob.displaybyid();
            ob.insert();
            Console.Read();
        }
    }
}
