using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //threaddemo ob = new threaddemo();
            ////Thread t1 = new Thread(ob.method1);
            ////t1.Start();
            //ob.method4();
            practice ob = new practice();

            ob.threadchecking();



            Console.Read();
            
        }
    }
}
