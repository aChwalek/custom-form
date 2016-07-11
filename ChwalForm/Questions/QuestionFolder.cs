using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChwalForm
{
    public class QuestionFolder : QuestionBase
    {
        List<QuestionBase> _questionsList;

        public QuestionFolder()
        {
            _questionsList = new List<QuestionBase>();
        }

        public QuestionBase AddQuestion(Type questionType)
        {
            QuestionBase q = (QuestionBase)Activator.CreateInstance(questionType);
            _questionsList.Add(q);
            q.Parent = this;
            return q;
        }

        public override T Accept<T>(IQuestionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
