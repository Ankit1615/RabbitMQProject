using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ONLINESHOP_API.Models;

namespace ONLINESHOP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineShopController : ControllerBase
    {
        ItrondbContext dc = new ItrondbContext();

        [HttpPost]
        [Route("registeruser")]
        public async Task<int> RegiserUser(Register r)// creates new user= registration page
        {
            dc.Register.Add(r);
            var res = await dc.SaveChangesAsync();
            return res;

        }
        [Route("display")]
        public async Task<List<Products>> GetProducts()
        {
            var res = from t in dc.Products
                      select t;
            return await dc.Products.ToListAsync();

        }
        [HttpPost]
        [Route("login")]
        public async Task<int> Login(Register r)
        {
            var res = from t in dc.Register
                      where t.Uname == r.Uname && t.Password == r.Password
                      select t;

            return await res.CountAsync();

        }

        [HttpPost]
        [Route("buy")]
        public int buynow(Userorders o)
        {
            dc.Userorders.Add(o);
            return dc.SaveChanges();

        }

    }
}
