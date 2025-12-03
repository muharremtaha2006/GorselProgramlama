using System;
using System.Collections.Generic;
using System.Linq;

namespace KelimeOyunu
{
    public class GameManager
    {
        public Puzzle Puzzle { get; private set; }
        public WordChecker Checker { get; private set; }
        public int Score { get; private set; } = 0;
        private Random rnd = new Random();

        public GameManager()
        {
            Checker = new WordChecker();
            StartNewGame();
        }

        public void StartNewGame()
        {
            Score = 0;
            Checker.UsedWords.Clear();

            // TurkishWords.txt'den rastgele kelime seç (en az 4 harfli)
            string word;
            do
            {
                word = Checker.Words[rnd.Next(Checker.Words.Count)];
            } while (word.Length < 4);

            Puzzle = new Puzzle();
            Puzzle.GenerateFromWord(word); // Kelimeye göre harf ve merkez harf üret
        }

        public bool TrySubmitWord(string word, out int addedScore)
        {
            addedScore = 0;
            if (!Checker.IsValidWord(word, Puzzle.Letters, Puzzle.CenterLetter))
                return false;

            addedScore = Checker.CalculateScore(word, Puzzle.Letters);
            Score += addedScore;
            Checker.UsedWords.Add(word.ToLower());

            return true;
        }

        public void Shuffle()
        {
            Puzzle.ShuffleLetters();
        }
    }
}
