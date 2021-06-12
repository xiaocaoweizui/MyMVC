using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebAPI.Models;

namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private PersonContext db;

        public PeopleController(PersonContext personContext)
        {
            db = personContext;
            db.People.Add(new Person { Name = "Ana", Id = 1, Age = 20 });
            db.People.Add(new Person { Name = "Felipe", Id = 2, Age = 21 });
            db.People.Add(new Person { Name = "Emillia", Id = 3, Age = 22 });

            
        }


        [HttpGet("people/all")]
        public ActionResult<IEnumerable<Person>> GetAll()
        {
            return new[]
            {
            new Person { Name = "Ana" },
            new Person { Name = "Felipe" },
            new Person { Name = "Emillia" }
        };
        }

        [HttpGet("people/{id}")]
        public ActionResult<Person> Get(int id)
        {
            var person = db.People.Find(new { id = 1 });

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        [HttpPost("people/create")]
        public IActionResult Create(Person person)
        {
           
            return Accepted();
        }
    }

  
}
