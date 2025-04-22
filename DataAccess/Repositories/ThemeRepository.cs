using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ThemeRepository:Repository<Theme>,IThemeRepository
    {
        private readonly TestSystemConext context;

        public ThemeRepository(TestSystemConext context)
            : base(context)
        {
            this.context = context;
        }
        public IEnumerable<Theme> GetThemesOfCourse(string course)
        {
            return new List<Theme>();   
        }
        public Theme GetThemeIncludeQuest(string theme)
        {
            return new Theme();
        }
        public Theme GetThemeIncludeQuestUnswer(string theme)
        {
            return new Theme();
        }
        public IEnumerable<Theme> GetThemesUserDone(string user)
        {
            return new List<Theme>();
        }
        public IEnumerable<Theme> GetThemesofCourseUserDone(string user, string course)
        {
            return new List<Theme>();
        }
    }
}
