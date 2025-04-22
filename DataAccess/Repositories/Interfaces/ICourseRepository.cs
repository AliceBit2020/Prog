using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Repositories.Interfaces
{
    internal interface ICourseRepository:IRepository<Course>
    {
        public IEnumerable<Course> GetCoursesIncludeUsers();

        public IEnumerable<Course> GetAvailableUserCourses(string user);


    }
}
