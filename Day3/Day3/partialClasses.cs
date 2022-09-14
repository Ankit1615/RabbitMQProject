using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
     internal partial class Empdet
    {
        public void DisplayAllEmp()
        {
            Console.WriteLine($"EMPID: {Empid} and EMPNAME: {EmpName} AND SALARY: {salary}");
        }

    }

    class BaseCls
    {
       public BaseCls( int a )
        {
            Console.WriteLine(a);
        } 
    }

    class DerivedCls:BaseCls
    {
       public DerivedCls(int b):base(b)
        {
            Console.WriteLine(b);
        }
    }

}
