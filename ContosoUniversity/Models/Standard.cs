using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Standard
    {


        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public string Description { get; set; }


        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}