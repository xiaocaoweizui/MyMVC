﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyWebAPI.Controllers
{
    /// <summary>
    /// 自定义约束
    /// </summary>
    public class MyCustomConstraint : IRouteConstraint
    {
        private Regex _regex;

        public MyCustomConstraint()
        {
            _regex = new Regex(@"^[1-9]$",
                                RegexOptions.CultureInvariant | RegexOptions.IgnoreCase,
                                TimeSpan.FromMilliseconds(100));
        }
        public bool Match(HttpContext httpContext, IRouter route, string routeKey,
                          RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (values.TryGetValue(routeKey, out object value))
            {
                var parameterValueString = Convert.ToString(value,
                                                            CultureInfo.InvariantCulture);
                if (parameterValueString == null)
                {
                    return false;
                }

                return _regex.IsMatch(parameterValueString);
            }

            return false;
        }
    }
}
