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
    public class MyResultFilter : ResultFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine($"我是在result输出后显示,执行前时间{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff")}");
            Console.WriteLine("---------------------------------------");
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"我是在result输出前显示,执行前时间{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff")}");
        }
    }
}
