using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ONLINESHOP_API.Models;

namespace ONLINESHOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyshopController : ControllerBase
    {
        
        ItrondbContext db = new ItrondbContext();
        //public string[] Get()
        //{
        //    string[] data = { "Vikramss", "RRR", "Bhahubali","KGF" };
        //    return data;
        //}
        //[Route("display")]
        //public List<Customers> Get()
        //{
        //    var data = (from t in db.Customers
        //                select t);

        //    return data.ToList();
        //}

        //[Route("displaybyid")]
        //public List<Customers> Getbyid(int id)
        //{
        //    var res = db.Customers.Where(c => c.Cuid == id).ToList();
        //    return res;

        //}

        //[Route("displaybyidname")]
        //public List<Customers> Getbyidandname(string name,int age)
        //{
        //    var data = db.Customers.Where(c => c.Age == age && c.Custname == name).ToList();
        //    return data;

        //}

        //public void Post([FromQuery]Customers c)
        //{
        //    db.Customers.Add(c);
        //    db.SaveChanges();
        //}
    }
}


