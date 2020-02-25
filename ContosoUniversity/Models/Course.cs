using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public System.Data.Entity.Spatial.DbGeography Location { get; set; }
        public Nullable<int> TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}