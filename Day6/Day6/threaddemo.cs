using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace Day6
{
    [Obsolete]
    internal class threaddemo
    {
        public void method1()
        {
            Thread t2 = new Thread(method2);


            for (int i = 0; i < 30; i++)
            {

                Console.WriteLine("Method1 is called");
              

                if (i == 5)
                {
                    t2.Start();
                }
                if (i == 10)
                {
                    t2.Suspend();
                }
                if (i == 15)
                {
                    t2.Resume();
                }
                if (i == 20)
                {
                    t2.Abort();
                }
                Thread.Sleep(1000);   
            }
        }

        public void method2()
        {

            while(true)
            {

                Console.WriteLine("method2 is called");
                Thread.Sleep(1000);

            }
            
        }

        public void method3()
        {
            Stopwatch s = Stopwatch.StartNew();
            Parallel.For(0, 16, (i) =>
            {
                Console.WriteLine(i);
            });

            s.Stop();
        Console.WriteLine(s.ElapsedMilliseconds);
        }

        public string Add(int a ,int b)
        {
            return "Sum = " + (a + b);
        }
        public async void method4()
        {
            string st = "";
           await Task.Run(() =>
            {
                st = Add(10, 15);
            });
            Console.WriteLine(st);
        }
    }
}
