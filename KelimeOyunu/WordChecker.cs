using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KelimeOyunu
{
    public class WordChecker
    {
        public List<string> Words { get; private set; }
        public HashSet<string> UsedWords { get; private set; } = new HashSet<string>();

        public WordChecker()
        {
            Words = LoadWordList("TurkishWords.txt");
        }

        private List<string> LoadWordList(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("TurkishWords.txt bulunamadı!");

            return File.ReadAllLines(path)
                       .Select(x => x.Trim().ToLower())
                       .Where(x => x.Length >= 4)
                       .ToList();
        }

        public bool IsValidWord(string word, List<char> allowedLetters, char centerLetter)
        {
            word = word.ToLower();

            // 1. Türkçe sözlükte olmalı
            if (!Words.Contains(word)) return false;

            // 2. En az 4 harfli olmalı
            if (word.Length < 4) return false;

            // 3. Merkez harf içermeli
            if (!word.Contains(centerLetter)) return false;

            // 4. Yalnızca verilen harflerle yazılmalı
            foreach (char c in word)
            {
                if (!allowedLetters.Contains(c))
                    return false;
            }

            // 5. Aynı kelime tekrar kullanılamaz
            if (UsedWords.Contains(word)) return false;

            return true;
        }

        public int CalculateScore(string word, List<char> letters)
        {
            int length = word.Length;
            int score = 0;

            if (length == 4) score = 1;
            else if (length == 5) score = 2;
            else if (length == 6) score = 3;
            else if (length >= 7) score = 4;

            // Pangram kontrolü
            if (letters.All(c => word.Contains(c)))
                score += 7;

            return score;
        }
    }
}
