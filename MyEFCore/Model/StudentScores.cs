using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEFCore.Models
{
  
    public class StudentScores
    {
        public string RecordName { get; set; }

        public Guid RecordID { get; set; }


        public Guid StudentID { get; set; }

        public int Score { get; set; }

        public string Class { get; set; }

        //public Student Student { get; set; }
    }
}
