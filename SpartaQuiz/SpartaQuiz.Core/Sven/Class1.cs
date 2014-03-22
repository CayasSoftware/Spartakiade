using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpartaQuiz.Core.Sven
{

    interface IGame
    {
        Guid StartGame(string username);

        QuestionItem GetNextQuestion(Guid gameSessionGiud);

        CheckQuestionResult CheckQuestion(Guid questionGuid, int answerNumber);

        GameSession GetCurrentGameSession(Guid gameSessionGuid);

        void CancelGame(Guid gameSessionGuid);

    }

    public class CheckQuestionResult
    {
        public int CorrectAnswer { get; set; }
    }

    public class GameSession
    {
        public Guid GameSessionGuid { get; set; }

        public string Username { get; set; }

        public int Score { get; set; }

        public bool IsGameOver { get; set; }
    }

    public class QuestionItem
    {
        public Guid GameSessionGuid { get; set; }

        public Guid QuestionGuid { get; set; }

        public string Question { get; set; }

        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }

    }
}
