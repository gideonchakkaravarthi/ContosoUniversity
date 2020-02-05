using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUniversity.Models;

namespace ContosoUniversity.ViewModels
{
    public class Course_Students
    {
        public Models.Course course { get; set; }
        public List<Student> students { get; set; }
    }
}