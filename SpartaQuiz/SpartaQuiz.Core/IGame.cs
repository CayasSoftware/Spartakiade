using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpartaQuiz.Core
{
    interface IGame
    {
        string PlayerName { get; }
        int Score { get; }

        QuestionItem GetCurrentQuestion();
        bool CheckAnswert(int answert);
    }

    public class Game : IGame
    {
        private readonly QuestionRepository _repository;
        private QuestionItem _current;

        public string PlayerName { get; private set; }
        public int Score { get; private set; }
        public bool GameOver { get; private set; }

        public Game(string playerName)
        {
            PlayerName = playerName;
            _repository = new QuestionRepository();
            _current = _repository.GetAQuestion();
        }

        public QuestionItem GetCurrentQuestion()
        {
            return _current;
        }

        public bool CheckAnswert(int answer)
        {
            if (_current.RightAnswer == answer)
            {
                _current = _repository.GetAQuestion();
                return true;
            }
            else
            {
                GameOver = true;
                _current = null;
                return false;
            }
        }
    }
}
