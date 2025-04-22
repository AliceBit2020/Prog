using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Answer
    {
        public Guid  Id { get; set; }= Guid.NewGuid();
        public IDictionary<string,bool> Answ { get; set; } = new Dictionary<string,bool>();

       
        public Question? Question { get; set; }

       

    }
}
