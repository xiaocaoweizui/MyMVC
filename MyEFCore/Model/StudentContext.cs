using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEFCore.Models
{
  

    public class StudentContext:DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Student> students { get; set; }

        private string connection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        public StudentContext(string connection) => this.connection = connection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // var connectionString = @"Data Source=XIAOCAO\MSSQLSERVER2014;Initial Catalog=Student;Integrated Security=True";
         //   optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////设置了Person实体ParentCodeNavigation属性和InverseParentCodeNavigation属性的父子关系（一对多关系，一个Person对多个Person）
            //modelBuilder.Entity<Student>()
            //    .HasMany(s => s.StudentScores)
            //    .WithOne(x => x.Student)
            //    .HasForeignKey(s => s.StudentID)
            //    .OnDelete(DeleteBehavior.Cascade);
                

            modelBuilder.Entity<StudentScores>()
               .ToTable("Students_Scores")
               .HasKey(t => t.RecordID);


        }
    }
}
