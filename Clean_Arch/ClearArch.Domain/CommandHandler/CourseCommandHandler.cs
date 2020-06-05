using ClearArch.Domain.Commands;
using ClearArch.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClearArch.Domain.CommandHandler
{
    public class CourseCommandHandler : IRequestHandler<CourseCommand, bool>
    {
        private readonly ICourseRespository _courseRespository;
        public CourseCommandHandler(ICourseRespository courseRespository)
        {
            _courseRespository = courseRespository;
        }
        public Task<bool> Handle(CourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course()
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };

            _courseRespository.Add(course);

            return Task.FromResult(true);
        }
    }
}
