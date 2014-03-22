using System;

namespace SpartaQuiz.Core
{
    public class GameSession
    {
        public Guid GameSessionGuid { get; set; }

        public string Username { get; set; }

        public int Score { get; set; }

        public bool IsGameOver { get; set; }
    }
}