using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ClassEnrollment.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ClassEnrollment.DataAccess
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() :base("SchoolContext") { }

        public DbSet<Student> Students { get; set; }
        public DbSet <Enrollment> Enrollments { get; set; }

        public DbSet <Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}