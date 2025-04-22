using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IQuestionRepostory:IRepository<Question>
    {
        public IEnumerable<Question> GetQuestionsIncAnswer(Theme theme);
        public IEnumerable<Question> GetQuestionsIncAnswerTheme(Course course);
    }
}
