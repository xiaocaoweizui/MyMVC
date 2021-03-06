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
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet()]   // GET /api/test
        public IActionResult Index()
        {
            return Content("Default");
        }

        [HttpGet("/product")]   // GET /product
        public IActionResult Product()
        {
            return Content("Product");
        }

        [HttpPost("product")]   // POST /api/test/product
        public IActionResult PostProducts()
        {
            return Content("PostProducts");
        }
        [HttpGet("product")]   // GET /api/test/product
        public IActionResult GetProducts()
        {
            return Content("GetProducts");
        }

        [HttpGet("~{id}")]   // GET /api/test/~xyz
        public IActionResult GetProduct(string id)
        {
            return Content(id);
        }


        [HttpGet("int/{id:int}")] // GET /api/test/int/3
        public IActionResult GetIntProduct(int id)
        {
            return Content($"int约束：{id}");
        }

        [HttpGet("int2/{id}")]  // GET /api/test/int2/3
        public IActionResult GetInt2Product(int id)
        {
            return Content($"int2 显示：{id}");
        }

        [HttpGet("custom/{id:customName}")]  // GET /api/test/custom/3
        public IActionResult ConstraintTest(int id)
        {
            return Content($"id只能是偶数：{id}");
        }
    }

  
}
