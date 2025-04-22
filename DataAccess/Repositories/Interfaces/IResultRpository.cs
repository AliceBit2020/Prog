using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IResultRpository:IRepository<TestResult>
    {
        public TestResult GetUserResultTheme(string userLogin, string theme);
        public IEnumerable<TestResult> GetUserResultCourse(string userLogin, string course);
        public IEnumerable<TestResult> GetAllUserResult(string userLogin);
        public IEnumerable<TestResult> GetAllResultInclude();
    }
}
