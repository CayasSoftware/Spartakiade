using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpartaQuiz.Core.Sven
{
    public class QuestionItem
    {
        public Guid GameSession { get; set; }

        public string Question { get; set; }

        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }

        public int CorrectAnswer { get; set; }

    }
}
