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
    public class MyAuthFilterAttribute : Attribute, IAuthorizationFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Console.WriteLine($"Authorization执行,执行前时间{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff")}");
        }
    }
}
