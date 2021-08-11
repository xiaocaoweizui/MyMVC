using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyEFCore.Models;
using Newtonsoft.Json;

namespace MyEFCore.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentController : ControllerBase
    {

        private readonly StudentContext db;

        public StudentController(StudentContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IEnumerable<Student> GetAll()
        {
            return db.students.Include(q=>q.StudentScores).ToList();
        }

        [HttpGet]
        public string GetAllStr()
        {
            return JsonConvert.SerializeObject(db.students.Include(q => q.StudentScores).ToList());
        }


        [HttpGet("{id:max(20)}")]
        public ActionResult<Student> Get(string code)
        {
            var person = db.students.FirstOrDefault(p => p.Code == code);
            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        [HttpPost()]
        public IActionResult Create([FromBody]Student person)
        {
          
            db.students.Add(person);
            db.SaveChanges();

            return Content("Create Success!");
        }


        [HttpPost()]
        public IActionResult Delete(string code)
        {
            //需要include才能删除
            var s = db.students.Where(s => s.Code == code).Include(q => q.StudentScores).FirstOrDefault();
            if (s != null)
            {
                db.students.Remove(s);
                db.SaveChanges();
            }
        

            return Content("Create Success!");
        }
    }
}
