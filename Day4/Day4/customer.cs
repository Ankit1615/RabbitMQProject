using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class customers
    {
        public int custid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public DateTime DOB { get; set; }

    }



    class customerdetails
    {

        List<customers> li = new List<customers>()
        {
            new customers(){  custid=100, name="abc", address="chennai", DOB= DateTime.Parse("1-1-2000")},
            new customers(){  custid=100, name="abc", address="chennai", DOB= DateTime.Parse("1-1-2000")},
            new customers(){  custid=100, name="abc", address="chennai", DOB= DateTime.Parse("1-1-2000")},
            new customers(){  custid=100, name="abc", address="chennai", DOB= DateTime.Parse("1-1-2000")},

        };

        public void Display()
        {
            foreach (customers item in li)
            {
                Console.WriteLine("customer id : " + item.custid + " Name : "+item.name + " Address : " + item.address );
            }
        }

    }
}
