using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChwalForm
{
    public interface IQuestionVisitor<T>
    {
        T Visit(QuestionRoot q);
        T Visit(QuestionFolder q);
        T Visit(BinaryQuestion q);
    }
}
