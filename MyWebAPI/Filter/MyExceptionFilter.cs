using Microsoft.AspNetCore.Mvc;
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
    public class MyExceptionFilterAttribute :ExceptionFilterAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void OnException(ExceptionContext context)
        {
            var ex = context.Exception;
            context.Result = new RedirectResult($"Error500");
            context.ExceptionHandled = true;
            base.OnException(context);
        }
    }
}
