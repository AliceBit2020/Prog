using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IThemeRepository:IRepository<Theme>
    {
        IEnumerable<Theme> GetThemesOfCourse(string course);
        Theme GetThemeIncludeQuest(string theme);
        Theme GetThemeIncludeQuestUnswer(string theme);
        IEnumerable<Theme> GetThemesUserDone(string user);
        IEnumerable<Theme> GetThemesofCourseUserDone(string user,string course);
    }
}
