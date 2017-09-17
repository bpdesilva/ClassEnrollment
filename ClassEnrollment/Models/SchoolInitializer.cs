using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassEnrollment.DataAccess;
namespace ClassEnrollment.Models
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var Students = new List<Student> {
                new Student{FirstName="Kamal",LastName="Ranasighe",EnrollemtnDate=DateTime.Parse("2017-09-01") },
                new Student{FirstName="Nimal",LastName="Chaturanga",EnrollemtnDate=DateTime.Parse("2017-09-02") },
                new Student{FirstName="Namal",LastName="Silva",EnrollemtnDate=DateTime.Parse("2017-09-11") }
            };

            Students.ForEach(s=> context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{CourseID=1005,Title="Developing C# Application",Credits=5},
                new Course{CourseID=1015,Title="Developing C# Application",Credits=5},
                new Course{CourseID=1025,Title="Developing C# Application",Credits=5}
            };

            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();

            var Enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1, CourseID=1005,Grade=Grade.A},
                new Enrollment{StudentID=2, CourseID=1025,Grade=Grade.C},
                new Enrollment{StudentID=3, CourseID=1015,Grade=Grade.F}
            };

            Enrollments.ForEach(e=>context.Enrollments.Add(e));
            context.SaveChanges();
        }
    }
}