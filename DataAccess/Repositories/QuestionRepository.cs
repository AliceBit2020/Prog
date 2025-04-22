using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class QuestionRepository:Repository<Question>,IQuestionRepostory
    {
        private readonly TestSystemConext context;

        public QuestionRepository(TestSystemConext context)
            : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Question> GetQuestionsIncAnswer(Theme theme)
        {
            return new List<Question>();
        }
        public IEnumerable<Question> GetQuestionsIncAnswerTheme(Course course)
        {
            return new List<Question>();
        }
    }
}
