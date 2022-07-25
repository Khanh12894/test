using System.Collections.Generic;

namespace WebApplication2.DTO
{
    public class StudentDTO
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public IList<StudentCourseDTO> StudentCourses { get; set; } = new List<StudentCourseDTO>();
    }
    public class StudentCourseDTO
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int CourseId { get; set; }
        public CourseDTO course { get; set; }
    }
}
