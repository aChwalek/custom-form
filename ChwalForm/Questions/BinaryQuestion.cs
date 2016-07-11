using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChwalForm
{
    public class BinaryQuestion : QuestionBase
    {

        public override T Accept<T>(IQuestionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
