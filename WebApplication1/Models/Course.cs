namespace WebApplication1.Models
{
    public class Course
    {
        public int ID { get; set; }
        public int Name { get; set; }

        public string Description { get; set; }

        public ICollection<StudentCourse> Enrollment { get; set; }
    }
}
