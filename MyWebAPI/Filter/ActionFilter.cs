using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Filter
{
    /// <summary>
    /// 
    /// </summary>
    public class MyActionFilterAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"我是在整个controller执行后显示,执行前时间{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff")}");
            Console.WriteLine("---------------------------------------");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"我是在整个controller前显示,执行前时间{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff")}");
        }

    }
      
}
