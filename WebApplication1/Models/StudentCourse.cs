namespace WebApplication1.Models
{
    public class StudentCourse
    {
        public int ID { get; set; }

        public string StudentID { get; set; }

        public int CourseID { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }
}
