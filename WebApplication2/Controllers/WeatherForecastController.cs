using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.DTO;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMapper _mapper;
        public WeatherForecastController(IMapper mapper) {
            _mapper = mapper;
        }
        SchoolContext context= new SchoolContext();
        [HttpPost]
        public bool Create(StudentModel model)
        {
            // map 
            Student st = new Student();
            st.Name=model.Name;
            //foreach (var studentCourseModel in model.StudentCourses)
            //{
            //    var sc = new StudentCourse();
            //    sc.StudentId = studentCourseModel.StudentId;
            //    sc.CourseId = studentCourseModel.CourseId;
            //    st.StudentCourses.Add(sc);
            //}
            st = _mapper.Map<Student>(model);
            st.StudentId = 0;
            context.Add(st);
            context.SaveChanges();
            return true;
        }
        [HttpGet]
        public async Task<object> GetStudents()
        {
            //var students = await context.Students.Include(p => p.StudentCourses).ThenInclude(p => p.Course).Select(p => new StudentDTO
            //{
            //    Name = p.Name,
            //    StudentId = p.StudentId,
            //    StudentCourses = _mapper.Map<List<StudentCourseDTO>>(p.StudentCourses)
            //}).ToListAsync();
            var students1 = context.Students.Include(p => p.StudentCourses).ThenInclude(p => p.Course);
            var requs = _mapper.Map<List<StudentDTO>>(students1);
            return requs;
            
        }
        [HttpPut]
        public bool update(StudentModel model)
        {
            var studen = context.Students.SingleOrDefault(p => p.StudentId == model.StudentId);
            context.Remove(studen);
            context.SaveChanges();
            // map 
            Student st = _mapper.Map<Student>(model);
            st.StudentId = 0;
            st.Name = model.Name;
            context.Add(st);
            context.SaveChanges();
            return true;
        }
    }
}
