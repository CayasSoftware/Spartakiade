using System;

namespace SpartaQuiz.Core
{
    interface IGameServer
    {
        Guid StartGame(string username);

        QuestionItem GetNextQuestion(Guid gameSessionGiud);

        CheckQuestionResult CheckQuestion(Guid questionGuid, int answerNumber);

        GameSession GetCurrentGameSession(Guid gameSessionGuid);

        void CancelGame(Guid gameSessionGuid);
    }
}