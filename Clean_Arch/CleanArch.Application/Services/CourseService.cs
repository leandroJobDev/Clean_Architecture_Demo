using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using ClearArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRespository _courseRespository;

        public CourseService(ICourseRespository courseRespository)
        {
            _courseRespository = courseRespository;
        }
        
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRespository.GetCourses()
            };
        }
    }
}
