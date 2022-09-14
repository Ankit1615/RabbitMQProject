using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class practice
    {
        public void linq()
        {
            int[] a = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            var result = from i in a
                         where i % 2 == 0
                         select i;
        }

        public void newdemo()
        {
            //var result = from i in li
            //             where i.price > 500
            //             select i;
            //string[] s = { "india", "nepal" };

            //var result2 = from i in s
            //              where i.ToUpper()
            //              select i;
            //int[] a = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            ////  var result3 = a.(t => t.price > 100 && t.price <1000).
            //var result3 = a.Where(t => t > 100 && t < 1000).OrderByDescending(t => t);
        }
    }
}
