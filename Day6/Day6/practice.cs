using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day6
{
    [Obsolete]
    internal class practice
    {
        public int Add(int a ,int b)
        {
            return (a + b);
        }
        
        public int Sub(int a,int b)
        {
            return (a - b);
        }

        public int mult(int a,int b)
        {
            return (a * b);
        }

        public async void show()
        {
            int add = 0 ;
            int multi = 0;
            int sub = 0;
           await Task.Run(() =>
            {
                add = Add(10, 15);
            });

            await Task.Run(() =>
            {
                multi = mult(10,15);   
            });

            await Task.Run(() =>
            {
                sub = Sub(add, multi);
            });

            Console.WriteLine("Sub : " + sub);

        }

        public async Task<string> ret(string s)
        {

            string st="";
            await Task.Run(() =>
            {
                st = "hellooooooo";
            });

            return st;
        }
        
        public async void display()
        {
            int a =0;
            int multi =0;
            await Task.Run(async () =>
            {
                a = Add(10, 15);
            }).ContinueWith(i =>
            {
               multi = mult(10, 15);
            });

            Console.WriteLine("add : "+ a + " Multiply : " + multi);

        }

        public void dis()
        {
            Console.WriteLine("Hero");
        }
        public void threadchecking()
        {
            Thread t = new Thread(dis);
            t.Start();
            if (t.IsAlive)
                Console.WriteLine("Active");
            else
                Console.WriteLine("Inactive");
        }
    }
}

