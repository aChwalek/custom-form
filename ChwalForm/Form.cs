using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChwalForm
{
    public class Form
    {
        private Dictionary<string, FormAnswer> _answers;
        private readonly QuestionRoot _questions;

        public QuestionRoot Questions
        {
            get { return _questions; }
        } 

        public string Title {
            get { return _questions.Title; }
            set { _questions.Title = value; }
        }


        public Form()
        {
            _answers = new Dictionary<string, FormAnswer>();
            _questions = new QuestionRoot(this);
        }

        public FormAnswer FindOrCreateAnswer(string key)
        {
            FormAnswer answer;
            _answers.TryGetValue(key, out answer);
            if (answer == null)
            {
                answer = new FormAnswer(key);
                _answers.Add(key, answer);
            }
            return answer;
        }
    }
}
