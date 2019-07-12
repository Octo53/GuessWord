using System;
using System.Collections.Generic;
using System.Text;

namespace WordGuess.Utils
{
    public static class QuestionUtils
    {
        public static string Shuffle(this string input)
        {
            Random rand = new Random();

            HashSet<int> indexSet = new HashSet<int>();
            var randomWord = string.Empty;
            while (true)
            {
                var nextIndex = rand.Next(1, input.Length + 1);
                if (!indexSet.Contains(nextIndex))
                {
                    indexSet.Add(nextIndex);
                    randomWord = randomWord + input[nextIndex - 1];
                }

                if (randomWord.Length == input.Length)
                {
                    if (!randomWord.Equals(input))
                    {
                        break;
                    }
                    randomWord = string.Empty;
                    indexSet.Clear();
                }
            }

            return randomWord;
        }
    }
}
