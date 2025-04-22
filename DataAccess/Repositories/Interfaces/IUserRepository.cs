using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Repositories.Interfaces
{
    public interface IUserRepository:IRepository<User>
    {
        public IEnumerable<User> GetUsersByCourse(string course);
        public bool IsExist(string user);
        public bool IsPassword(User user);

        public string Role(string user);
        
 
  

    }
}
