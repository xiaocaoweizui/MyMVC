using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{ 
    public  static class MyDBExtension
    {

        public static IServiceCollection AddMyDb(this IServiceCollection services,string conn)
        {
            services.AddDbContext<StudentContext>(options =>options.UseSqlServer(conn));
            return services;
        }

    }
}
