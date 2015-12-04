using EmptyWebAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace EmptyWebAPI.Controllers
{
    public class StudentController : ApiController
    {
        // Data source
        List<Student> db = new List<Student>();
        public StudentController()
        {
            db = new List<Student>
            {
                new Student { Id = 1, Name = "Abhimanyu K Vatsa", City = "Bokaro" },
                new Student { Id = 2, Name = "Deepak Kumar Gupta", City = "Bokaro" },
                new Student { Id = 3, Name = "Manish Kumar", City = "Muzaffarpur" },
                new Student { Id = 4, Name = "Rohit Ranjan", City = "Patna" },
                new Student { Id = 5, Name = "Shiv", City = "Motihari" },
                new Student { Id = 6, Name = "Rajesh Singh", City = "Dhanbad" },
                new Student { Id = 7, Name = "Staya", City = "Bokaro" },
                new Student { Id = 8, Name = "Samiran", City = "Chas" },
                new Student { Id = 9, Name = "Rajnish", City = "Bokaro" },
                new Student { Id = 10, Name = "Mahtab", City = "Dhanbad" }
            };
        }

        public IHttpActionResult Get(string sort = "id", int page = 1, int pageSize = 5)
        {
            return Ok(db);
        }

    }
}
