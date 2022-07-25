using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public IList<StudentCourseModel> StudentCourses { get; set; }
    }
    public class StudentCourseModel
    {
        public int StudentId { get; set; }

        public int CourseId { get; set; }
    }
}
