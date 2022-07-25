using AutoMapper;
using WebApplication2.DTO;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<StudentCourse, StudentCourseDTO>().ReverseMap();
           CreateMap<Course, CourseDTO>().ReverseMap();

            CreateMap<Student, StudentModel>().ReverseMap();
            CreateMap<StudentCourse, StudentCourseModel>().ReverseMap();
           // CreateMap<Course, CourseModel>().ReverseMap();
        }
    }


}
