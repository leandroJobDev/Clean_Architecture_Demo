using System;
using System.Collections.Generic;
using System.Text;
//ing ClearArch.Domain.Models;

namespace ClearArch.Domain.Interfaces
{
    public interface ICourseRespository
    {   
        IEnumerable<Course> GetCourses();
    }
}
