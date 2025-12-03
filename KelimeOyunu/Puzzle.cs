using System;
using System.Collections.Generic;
using System.Linq;

namespace KelimeOyunu
{
    public class Puzzle
    {
        public List<char> Letters { get; private set; }
        public char CenterLetter { get; private set; }
        private Random rnd = new Random();

        public void GenerateFromWord(string word)
        {
            // Kelimenin harflerini listeye ekle
            Letters = word.ToLower().Distinct().ToList();

            // Merkez harfi kelimenin harflerinden rastgele seç
            CenterLetter = Letters[rnd.Next(Letters.Count)];

            // Eğer harf sayısı < 7 ise rastgele harf ekle
            string turkishAlphabet = "abcçdefgğhıijklmnoöprsştuüvyz";
            while (Letters.Count < 7)
            {
                char c = turkishAlphabet[rnd.Next(turkishAlphabet.Length)];
                if (!Letters.Contains(c))
                    Letters.Add(c);
            }

            // 7 harfi rastgele sırala
            Letters = Letters.OrderBy(x => rnd.Next()).ToList();

            // Merkez harfi listede sabit tutmak için
            if (!Letters.Contains(CenterLetter))
                Letters[0] = CenterLetter;
        }

        public void ShuffleLetters()
        {
            Letters = Letters.OrderBy(x => rnd.Next()).ToList();
            // Merkez harfi sabit tutmak için
            if (!Letters.Contains(CenterLetter))
                Letters[0] = CenterLetter;
        }
    }
}
