using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ResultRepository:Repository<TestResult>,IResultRpository
    {
        private readonly TestSystemConext context;

        public ResultRepository(TestSystemConext context)
            : base(context)
        {
            this.context = context;
        }
        public TestResult GetUserResultTheme(string userLogin, string theme)
        {
            return new TestResult();
        }
        public IEnumerable<TestResult> GetUserResultCourse(string userLogin, string course)
        {
            return new List<TestResult>();
        }
        public IEnumerable<TestResult> GetAllUserResult(string userLogin)
        {
            return new List<TestResult>();
        }
        public IEnumerable<TestResult> GetAllResultInclude()
        {
            return new List<TestResult>();
        }
    }
}
