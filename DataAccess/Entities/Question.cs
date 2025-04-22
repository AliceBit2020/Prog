using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Question
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public string Quest { get; set; }=string.Empty;
        public Guid CourseId { get; set; }
        public Guid ThemeId { get; set; }
        public Guid AnswerId { get; set; }
        public Course? Course { get; set; } 
        public Theme? Theme { get; set; } 
        public virtual Answer? Answer { get; set; }

     
       
       
    }
}
