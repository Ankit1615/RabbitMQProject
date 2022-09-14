using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentDay2
{
    internal class assignmentDay2
    {
       public void commoninarray()
        {
            int[] array1 = { 45,78,45,34,65,89 };
            int[] array2 = { 78, 4, 8, 9, 65, 3, 7, 34 };

            IEnumerable<int> array3 = array1.Intersect(array2);

            foreach (var item in array3)
            {
                Console.WriteLine(item);
            }

        }

        public void evenno()
        {
            int[] arr = { 10, 11, 12, 13, 14, 15, 16 };
            foreach (var item in arr)
            {
                if(item % 2 == 0)
                    Console.WriteLine(item);
            }
        }
        public void uppercase()
        {
            string[] s = { "india", "canada", "us", "uk" };
            foreach (var item in s)
            {
                Console.WriteLine(item.ToUpper());
            }
        }

        public void contain()
        {
            string[] s = { "india", "canada", "us", "uk" };
            foreach (var item in s)
            {
                if(item.Contains("a"))
                    Console.WriteLine(item);
            }
        }

        public static void GetData()
        {
            object[] myobject = new object[5];
            myobject[0] = "hello";
            myobject[1] = 123;
            myobject[2] = 123.4;
            myobject[3] = null;
            myobject[4] = "CGI";
            foreach (var item in myobject)
            {
                if (item is string)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void sumationOfFirstRow()
        {
            int[,] arr = new int[3,3];   
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = 0;

            for(int i=0; i < 3; i++)
            {
                sum = sum + arr[i, 0];
            }
            Console.WriteLine($"The sum of first row is : {sum}");
            
        }

        public void startsWithS()
        {
            string[] st = {"Srilanka","Singapore","India","Swedan","Canada"};
            foreach (var item in st)
            {
                int lenghts = item.Length;
                if (lenghts > 7 && item.StartsWith("S"))
                {
                    Console.WriteLine(item.ToUpper());
                }
            }

        }


    }
    public class Empclass
    {
        public int EmpId;
        public string EmpFirstname;
        public string EmpLastname;
        public double salary;
        public string dept;

        public void displayFullName()
        {
            Console.WriteLine(EmpId);
            Console.WriteLine(EmpFirstname);
            Console.WriteLine(EmpLastname);
            Console.WriteLine(salary);
            Console.WriteLine(dept);
        }
        public void CalculateAnnualSalary()
        {
            Console.WriteLine(salary * 0.80);
        }
    }

    public class Student
    {
       public int studentId;
       public string studentName;
        public int i;
        public int marks 
        {
            set
            {
                i = value;
                if(i > 60)
                    Console.WriteLine("First Class");
                if(i <60 && i>50)
                    Console.WriteLine("Second class");
                if(i<50)
                    Console.WriteLine("Fail");
            }
        }
        public void GetDetails()
        {
            Console.WriteLine($"Student Id : {studentId}");
            Console.WriteLine($"Student Name : {studentName}");
            Console.WriteLine($"Student Marks : {i}");
        }
    }


}
