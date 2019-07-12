using System;
using System.Collections.Generic;
using System.Linq;
using WordGuess.Business;
using WordGuess.Model;
using WordGuess.Utils;

namespace WordGuess
{
    class Program
    {
        static int points = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            Question questionObj = new Question();
            Answer answerObj = new Answer();
            Point pointObj = new Point();

            while (true)
            {
                var currentQuestion = questionObj.GetQuestion();
                if(currentQuestion == null)
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine($"Word to guess : {currentQuestion.ShuffleWord}");
                Console.Write("Answer : ");
                var userInput = Console.ReadLine();

                var flag = answerObj.CheckAnswer(userInput, currentQuestion.OriginWord);
                if (flag)
                {
                    pointObj.AddPoint();
                    Console.WriteLine($"Good Job ! You get a point for correct answer.");
                    continue;
                }

                Console.WriteLine(answerObj.GetReason(userInput, currentQuestion.OriginWord));
                Console.WriteLine($"Correct Letters : {answerObj.GetCorectLetters(userInput, currentQuestion.OriginWord)}");
            }

            Console.WriteLine();
            Console.WriteLine($"Game over. Yout Get : {pointObj.GetPoints()} Points.");
            Console.WriteLine($"Hit enter to exit..");
            Console.ReadLine();
        }
    }
}
