using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Models
{
    public class PersonContext:DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options): base(options)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
