using Clean.Arch.Domain.Core.Bus;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using ClearArch.Domain.Commands;
using ClearArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRespository _courseRespository;

        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRespository courseRespository, IMediatorHandler bus)
        {
            _courseRespository = courseRespository;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand   (
                courseViewModel.Name,
                courseViewModel.Description,
                courseViewModel.ImageUrl
                );
             
            _bus.SendCommand(createCourseCommand);
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
