using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace DataAccess.Repositories
{
    public class Repository<T>: IRepository<T> where T : class
    {
        protected DbContext dbc;
        protected Repository(DbContext context)
        {
            dbc = context;
        }
        public IEnumerable<T> GetAll()=>dbc.Set<T>().ToList();
        public T? GetById<IdT>(IdT id) => dbc.Set<T>().Find(id);

        public void Add(T entity)=>dbc.Set<T>().Add(entity);
    }
}
