using Microsoft.Extensions.DependencyInjection;
using MyWebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{ 
    public  static class MyConstraintExtension
    {

        public static IServiceCollection AddMyConstraint(this IServiceCollection services)
        {
            //增加自定义约束
            services.AddRouting(options =>
            {
                options.ConstraintMap.Add("customName", typeof(MyCustomConstraint));
            });
            return services;
        }

    }
}
