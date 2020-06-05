using System;
using System.Collections.Generic;
using System.Text;
//using ClearArch.Domain.Models;

namespace ClearArch.Domain.Interfaces
{
    public interface ICourseRespository
    {   
        IEnumerable<Course> GetCourses();
        void Add(Course course);
    }
}
