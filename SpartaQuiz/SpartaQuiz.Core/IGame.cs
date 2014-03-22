using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpartaQuiz.Core
{
	interface IGame
	{
		string PlayerName { get; }

		int Score { get; }

		bool GameOver
		{
			get;
		}

		QuestionItem GetCurrentQuestion();

		bool CheckAnswert( int answert );
	}
}
