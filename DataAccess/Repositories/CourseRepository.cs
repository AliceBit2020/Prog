using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CourseRepository: Repository<Course>, ICourseRepository
    {
        private readonly TestSystemConext context;

        public CourseRepository(TestSystemConext context)
            : base(context)
        {
            this.context = context;
        }
        public IEnumerable<Course> GetCoursesIncludeUsers()
        {
            return new List<Course>();
        }

        public IEnumerable<Course> GetAvailableUserCourses(string user)
        {
            return new List<Course>();
        }
    }
}
