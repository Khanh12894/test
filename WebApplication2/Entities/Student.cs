using System.Collections.Generic;

namespace WebApplication2.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }=new List<StudentCourse>();

    }
}
