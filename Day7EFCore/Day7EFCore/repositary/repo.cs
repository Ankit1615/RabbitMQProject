using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day7EFCore.Models;

namespace Day7EFCore.repositary
{
    internal class repo
    {
        ItrondbContext db = new ItrondbContext();
        public void insert<T>(T tble) where T : class
        {
            db.Add(tble);
            db.SaveChanges();
            Console.WriteLine("Successfully inserted!");
        }
        public void delete()
        {

        }
    }
}
