using System;
using System.Collections.Generic;
using System.Text;

namespace WordGuess.Business
{
    public class Answer
    {

        // Check Answer
        public bool CheckAnswer(string input, string correctAnswer)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            if (input.ToLower().Equals(correctAnswer))
            {
                return true;
            }

            return false;
        }

        public string GetReason(string input, string correctAnswer)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "Answer cannot be empty. Hence considered wrong";
            }

            if (!input.ToLower().Equals(correctAnswer))
            {
                return $"Incorrect answer !";
            }

            return string.Empty;
        }

        public string GetCorectLetters(string input, string correctAnswer)
        {
            var correctLetters = "";

            for (int i = 0; i < correctAnswer.Length; i++)
            {
                var inputChar = i < input.Length ? input[i] : ' ';
                if (correctAnswer[i] == inputChar)
                {
                    correctLetters = correctLetters + $"{inputChar}";
                    continue;
                }
                correctLetters = correctLetters + "*";
            }

            return correctLetters;

        }
    }
}
