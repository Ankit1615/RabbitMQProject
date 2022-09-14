using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class demo
    {
        public delegate string mydel(int x,int y);

        public string sum(int x, int y)
        {

            return (x + y) % 2 == 0 ? "Sum : true" : "Sum : false";
        }

        public string  sub(int x,int y)
        {
            return (x + y) % 2 == 0 ? "Sub : true" : "Sum : false";
        }

        public void display(int x,int y)
        {
            mydel ob;
            if(x > 7 )
            {
                ob = sum;
               //Ananymous  ---->  ob = delegate (int m,int n) { return (m + n) % 2 == 0 ? "Sum : true" : "Sum : false"; };
              //lamda function --->  ob = (int m, int n) => { return (m + n) % 2 == 0 ? "Sum : true" : "Sum : false"; };
            }
            else
            {
                ob = sub;
            }

            Console.WriteLine(ob.Invoke(x, y));
        }
    }
    class multidele
    {
        public delegate void mymultidel();
        public void method1()
        {
            Console.WriteLine("method1 called");
        }

        public void method2()
        {
            Console.WriteLine("method2 called");
        }

        public void method3()
        {
            Console.WriteLine("method3 called");
        }

        public void show()
        {
            // multi cast demo

            mymultidel d1 = method1;

            mymultidel d2 = method2;

            mymultidel d3;

            //   mymultidel d3 = method3;

            d3 = d1 + d2;

            d3.Invoke();

        }
    }
}
