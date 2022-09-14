using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            assignmentDay2 ob = new assignmentDay2();
            //ob.commoninarray();
            // ob.evenno();
            //ob.uppercase();
            //ob.contain();
            //ob.sumationOfFirstRow();
            //ob.startsWithS();
            //Empclass ob1 = new Empclass();

            //ob1.EmpId = 123;
            //ob1.EmpFirstname = "Ankit";
            //ob1.EmpLastname = "Yadav";
            //ob1.dept = "IT";
            //ob1.salary = 100000;

            //ob1.displayFullName();
            //ob1.CalculateAnnualSalary();
            //Console.Read();
            //Student obb = new Student();
            //Console.WriteLine("Enter your name:");
            //obb.studentName =  Console.ReadLine();
            //Console.WriteLine("Please enter your emp id :");
            //obb.studentId = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your Marks :");
            //obb.marks = int.Parse(Console.ReadLine());
            //obb.GetDetails();

            Student[] obb = new Student[5];


            for (int i = 0; i < 5; i++)
            {
                obb[i] = new Student();
                Console.WriteLine("Enter your name:");
                obb[i].studentName = Console.ReadLine();
                Console.WriteLine("Please enter your emp id :");
                obb[i].studentId = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your Marks :");
                obb[i].marks = int.Parse(Console.ReadLine());
                obb[i].GetDetails();

            }





        }
    }
}
