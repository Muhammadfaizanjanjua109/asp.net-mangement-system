﻿namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public ICollection<StudentCourse> Enrollment { get; set; }
    }
}
