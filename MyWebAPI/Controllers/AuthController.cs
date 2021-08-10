using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Filter;

namespace MyWebAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [MyActionFilter]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthController : Controller
    {

        [MyActionFilter2]
        public IActionResult Index()
        {
            Console.WriteLine($"action（Index）执行,执行前时间{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff")}");
            return Content("Index");
        }
        [MyResultFilter]
        public IActionResult Result()
        {
            Console.WriteLine($"action（Result）执行,执行前时间{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff")}");
            return Content("Result");
        }

        [MyAuthFilter]
        public IActionResult AuthTest()
        {
            Console.WriteLine($"action（AuthTest）执行,执行前时间{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff")}");
            return Content("Result");
        }


        [MyExceptionFilter]
        public IActionResult GetException()
        {
            Console.WriteLine($"action（GetException）执行,执行前时间{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff")}");
            int a = 0;
            int b = 111;
            int c = b / a;
            return Content("GetException");
        }

        public IActionResult Error500()
        {
            return Content("500");
        }
    }
}