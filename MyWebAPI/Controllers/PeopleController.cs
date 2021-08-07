using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using MyWebAPI.Models;

namespace MyWebAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private PersonContext db;

        public PeopleController(PersonContext personContext)
        {
            db = personContext;
            if (!db.People.Any())
            {
                db.People.Add(new Person { Id = 1, Name = "Ana", Age = 20 });
                db.People.Add(new Person { Id = 2, Name = "Felipe", Age = 21 });
                db.People.Add(new Person { Id = 3, Name = "Emillia", Age = 22 });

                db.SaveChanges();
            }

        }

        [HttpGet]
        public IActionResult Index()
        {
            return Content("Index");
        }


        [HttpGet]
        public IEnumerable<Person> GetAll()
        {
            return db.People.ToList();
        }

        [HttpGet("{id:max(20)}")]
        public ActionResult<Person> Get(int id)
        {
            if (id == 0)
            {
                return StatusCode(StatusCodes.Status406NotAcceptable);
            }

            var person = db.People.FirstOrDefault(p => p.Id == id);

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        [HttpPost()]
        public IActionResult Create([FromBody]Person person)
        {
            db.People.Add(person);
            db.SaveChanges();

            return Content("Create Success!");
        }

        [HttpGet("{bookId:customName}")]
        public IActionResult GetParams(int bookId)
        {
            //https://localhost:5001/api/people/getparams/111?bookId=13
            var id = Request.Query["bookId"];
            var id2 = RouteData.Values["bookId"];
            return Content($"id={id},id2={id2}");
        }



        [HttpGet]
        public bool GetUrl([FromServices]LinkGenerator linkGenerator)
        {
            var s = linkGenerator.GetPathByAction(HttpContext, action: "Get", controller: "WeatherForecast", values: null);

            var uri = linkGenerator.GetUriByAction(HttpContext, action: "Get", controller: "WeatherForecast", values: null);

            return true;
        }
    }

  
}
