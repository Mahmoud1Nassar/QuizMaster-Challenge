using System;
using System.Collections.Generic;

namespace QuizMaster_Challenge
{
    internal class Quiz
    {
        public static void StartQuiz()
        {
            try
            {
                Questions();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        private static void Questions()
        {
            int mark = 0;
            var quiz = new Dictionary<string, string>
            {
                { "What is the capital of France?", "paris" },
                { "Who wrote the play 'Romeo and Juliet'?", "shakespeare" },
                { "What is the largest planet in our solar system?", "jupiter" },
                { "Who was the first president of the United States?", "george washington" },
                { "What element does 'O' represent on the periodic table?", "oxygen" },
                { "What is the longest river in the world?", "nile" },
                { "In what year did the Titanic sink?", "1912" },
                { "What is the boiling point of water in degrees Celsius?", "100" },
                { "Who painted the Mona Lisa?", "leonardo da vinci" },
                { "What is the largest ocean on Earth?", "pacific" }
            };

            foreach (var question in quiz)
            {
                Console.WriteLine(question.Key);

                string answer = null;
                bool validInput = false;

                while (!validInput)
                {
                    try
                    {
                        answer = Console.ReadLine()?.ToLower().Trim();
                        if (string.IsNullOrEmpty(answer))
                        {
                            throw new InvalidOperationException("Input cannot be empty. Please try again.");
                        }

                        validInput = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Invalid input: {ex.Message}");
                    }
                }

                if (answer == question.Value)
                {
                    mark++;
                }
                else
                {
                    Console.WriteLine($"The right answer is {question.Value}");
                }
            }

            Console.WriteLine($"You scored {mark} out of {quiz.Count}");
        }
    }
}
