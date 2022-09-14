using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day7EFCore.Models;
using Day7EFCore.repositary;

namespace Day7EFCore
{
    internal class Class1
    {
        ItrondbContext db = new ItrondbContext();
        repo r = new repo();   
        public void insert()
        {
            Customers ob = new Customers();
            ob.Cuid = 456;
            ob.Caddress = "Bihar siwan";
            ob.Custname = "Rameshwar Yadav";
            ob.Age = 80;
            r.insert(ob);
            //db.Customers.Add(ob);
            //db.SaveChanges();
        }



    }
}
