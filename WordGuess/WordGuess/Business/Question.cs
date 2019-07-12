using System;
using System.Collections.Generic;
using System.Text;
using WordGuess.Model;
using WordGuess.Utils;

namespace WordGuess.Business
{
    public class Question
    {
        static string base_words = "fish,chicken,cows,pig,deer,horse";
        static string[] wordsArray = null;

        int currentQuestion = 0;

        public QuestionViewModel GetQuestion()
        {
            if(wordsArray == null)
            {
                _InitWords();
            }

            if(currentQuestion < wordsArray.Length)
            {
                var word = wordsArray[currentQuestion];
                currentQuestion++;

                return new QuestionViewModel()
                {
                    OriginWord = word,
                    ShuffleWord = word.Shuffle()
                };
            }
            else
            {
                return null;
            }
        }

        private void _InitWords()
        {
            wordsArray = base_words.Split(",");
        }
    }
}
