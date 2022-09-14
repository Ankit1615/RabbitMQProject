using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;


namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class jobController : ControllerBase
    {
        public string s = "";
        private static IWebHostEnvironment _env;

        public jobController(IWebHostEnvironment env)
        {
            _env = env;

        }

        //[HttpPost]
        //[Route("upload")]
        //public async Task<string> upload([FromForm]uploadfile obj)
        //{
        //            if(!Directory.Exists(_env.WebRootPath + "\\Images\\"))
        //            {
        //                Directory.CreateDirectory(_env.WebRootPath + "\\Images\\");
        //            }
        //            using(FileStream filestrem = System.IO.File.Create(_env.WebRootPath + "\\Images\\" + obj.file.FileName))
        //            {
        //                obj.file.CopyTo(filestrem);
        //                filestrem.Flush();
        //                return "\\Images\\" + obj.file.FileName;
        //            }

               
         
        //}


        [HttpPost, DisableRequestSizeLimit]
        [Route("upload")]
        public async Task<IActionResult> Upload()
        {
            try
            {
                var formCollection = await Request.ReadFormAsync();
                var file = formCollection.Files.First();
                var folderName = Path.Combine("wwwroot", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                    var fileName = System.Net.Http.Headers.ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        projectdbContext db = new projectdbContext();

        [Route("display")]
        public async Task<List<Companydetails>> GetCustomer()
        {
            var res = from t in db.Companydetails select t;
            return await db.Companydetails.ToListAsync();

        }

        [HttpPost]
        [Route("login")]
        public async Task<int> Login(Jobregister r)
        {
            var res = from t in db.Register
                      where t.Uname == r.Email && t.Password == r.Password
                      select t;

            int k = res.Count();
            return await res.CountAsync();

        }

        
        [HttpPost]
        [Route("registeruser")]
        public async Task<int> RegiserUser(Jobregister obj)
        {
            
            db.Jobregister.Add(obj);      
            var res = await db.SaveChangesAsync();     
            return res;
        }


        [Route("rqteam")]
        public async Task<IEnumerable<dynamic>> recquitment()
        {
            var res = from t in db.Apply
                      where t.Status == "pending"
                      join i in db.Jobregister 
                      on t.Applicantid equals i.Id
                       select new
                       {
                            candidateid = i.Id,
                            fname = i.Fname,
                            email = i.Email,
                            mobile = i.Mobile,
                            Experianced = i.Workstatus,
                            DOB = i.Dob,
                            resume = i.Resumes,
                            coampanyid = t.Companyid,
                            status = t.Status
                                    
                       };

            return await res.ToListAsync();

        }

        [HttpPost]
        [Route("appliedcandidate")]
        public async Task<int> appliedcandidate(Apply obj)
        {
            obj.Status = "pending";
            db.Apply.Add(obj);
            var res = await db.SaveChangesAsync();
            return res;
        }


        [HttpPost]
        [Route("approved")]
        public async Task<int> approved(Apply obj)
        {
        #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Apply result =  (from i in db.Apply
                          where i.Applicantid == obj.Applicantid
                          select i
                          ).SingleOrDefault();
        #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            result.Status = "approved";

            var res = await db.SaveChangesAsync();
            return res;
        }


        [HttpPost]
        [Route("rejected")]
        public async Task<int> rejected(Apply obj)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Apply result = (from i in db.Apply
                            where i.Applicantid == obj.Applicantid
                            select i
                          ).SingleOrDefault();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            result.Status = "rejected";

            var res = await db.SaveChangesAsync();
            return res;
        }


        [Route("jobdetails")]
        public async Task<List<Jobdetails>> jobdetails()
        {
            var res = from t in db.Jobdetails select t;
            return await db.Jobdetails.ToListAsync();

        }

        [Route("getrecdetails")]
        public async Task<IEnumerable<dynamic>> getrecdetails()
        {
            var res = from t in db.Apply
                      where t.Status != "pending"
                      join i in db.Jobregister
                      on t.Applicantid equals i.Id
                      select new
                      {
                          candidateid = i.Id,
                          fname = i.Fname,
                          email = i.Email,
                          mobile = i.Mobile,
                          Experianced = i.Workstatus,
                          DOB = i.Dob,
                          resume = i.Resumes,
                          coampanyid = t.Companyid,
                          status = t.Status

                      };

            return await res.ToListAsync();

        }





    }
}




