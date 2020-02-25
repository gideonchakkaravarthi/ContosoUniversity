namespace ContosoUniversity.Models
{
    public class Student
    {
        public int StudentId { get; set; }    
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string StandardId { get; set; }
        public int RowVersion { get; set; }


    }
}