using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChwalForm
{
    public abstract class QuestionBase
    {
        public string Title { get; set; }
        public string Index { get; set; }
        public QuestionBase Parent { get; set; }
        public virtual Form Form => Parent?.Form;
        public abstract T Accept<T>(IQuestionVisitor<T> v);
    }
}
