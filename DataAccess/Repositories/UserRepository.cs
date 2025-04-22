using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;

namespace DataAccess.Repositories
{
    public class UserRepository: Repository<User>,IUserRepository
    {
        private readonly TestSystemConext context;

        public UserRepository(TestSystemConext context)
            : base(context)
        {
            this.context = context;
        }
        public IEnumerable<User> GetUsersByCourse(string course)
        {
            return new List<User>();
        }
        public bool IsExist(string user)
        {
            return false;
        }
        public bool IsPassword(User user)
        {
            return false;
        }

        public string Role(string user)
        {
            return "user";
        }



    }
}
