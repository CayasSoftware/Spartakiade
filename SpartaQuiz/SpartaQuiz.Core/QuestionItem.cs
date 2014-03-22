using System;

namespace SpartaQuiz.Core
{
    public class QuestionItem
    {
        public Guid QuestionGuid { get; set; }

        public string Question { get; set; }

        public string[] Answers { get; set; }

        public int RightAnswer { get; set; }
    }
}