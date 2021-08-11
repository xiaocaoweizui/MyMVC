using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEFCore.Models
{
  
    public class Student
    {
        public string Name { get; set; }

        public Guid Id { get; set; }


        public string Sex { get; set; }

        public string Code { get; set; }

        public List<StudentScores> StudentScores { get; set; }
    }

}
