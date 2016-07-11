using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChwalForm
{
    public class QuestionRoot : QuestionFolder
    {
        Form _form;
        public override Form Form => _form;

        public QuestionRoot(Form f)
        {
            _form = f;
        }

        public override T Accept<T>(IQuestionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
