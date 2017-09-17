using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassEnrollment.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollemtnDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}