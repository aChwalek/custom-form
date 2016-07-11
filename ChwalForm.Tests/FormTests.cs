using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ChwalForm;

namespace ChwalForm.Tests
{
    [TestFixture]
    public class FormTests
    {
        [Test]
        public void set_form_title()
        {
            Form f = new Form();
            Assert.IsNull(f.Title);
            f.Title = "My form";
            Assert.AreEqual(f.Title, "My form");
        }

        [Test]
        public void create_answer()
        {
            Form f = new Form();
            FormAnswer daveAnswer = f.FindOrCreateAnswer("Dave");
            FormAnswer daveAnswer2 = f.FindOrCreateAnswer("Dave");

            FormAnswer guiguiAnswer = f.FindOrCreateAnswer("Guigui");

            Assert.AreSame(daveAnswer, daveAnswer2);
            Assert.AreNotSame(daveAnswer, guiguiAnswer);
        }

        [Test]
        public void create_questions()
        {
            Form f = new Form();
            QuestionBase q = f.Questions.AddQuestion(typeof(QuestionFolder));
            Assert.IsNotNull(q);
            Assert.AreSame(q.Form, f);
        }
    }
}
