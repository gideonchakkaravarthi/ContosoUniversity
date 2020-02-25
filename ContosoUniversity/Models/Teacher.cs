using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public Nullable<int> StandardId { get; set; }
        public Nullable<int> TeacherType { get; set; }


        public virtual ICollection<Course> Courses { get; set; }
        public virtual Standard Standard { get; set; }
    }
}