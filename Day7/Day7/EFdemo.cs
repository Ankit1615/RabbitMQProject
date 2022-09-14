using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class EFdemo
    {
        ItrondbEntities db = new ItrondbEntities();

        public void diplaycustomer()
        {
            var result = from t in db.customers
                         select t;

            foreach (var item in result)
            {
                Console.WriteLine(item.cuid);
            }
        }

        public void displaybyid()
        {
            Console.WriteLine("Please enter the id");
            int id = int.Parse(Console.ReadLine());

            var result = (from t in db.customers
                          where t.cuid == id
                          select t).FirstOrDefault();

            Console.WriteLine(result.caddress);
        }

        public void insert()
        {
            customer ob = new customer();
            ob.cuid = 123;
            ob.age = 23;
            ob.custname = "arbind";
            ob.caddress = "patna";
            db.customers.Add(ob);
            db.SaveChanges();
            Console.WriteLine("Record successfully updated");
        }

        public void update()
        {
            Console.WriteLine("Please enter the id: ");
            int id = int.Parse(Console.ReadLine());
            var result = (from i in db.customers
                          where i.cuid == id
                          select i).FirstOrDefault();
            result.caddress = "Bihar";
            db.SaveChanges();
            Console.WriteLine("Record successfully updated!");
        }

    }
}
