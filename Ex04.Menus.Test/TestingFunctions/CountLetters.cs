using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.TestingFunctions
{
    public class CountLetters : IDoActionListener
    {
        public void DoAction()
        {
            CountLettersAction();
        }

        private void CountLettersAction()
        {
            Console.WriteLine("Please enter a sentence:");
            string userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("You didn't enter a sentence!");
                return;
            }

            int lowercaseCount = 0;

            foreach (char c in userInput)
            {
                if (char.IsLower(c))
                {
                    lowercaseCount++;
                }
            }

            Console.WriteLine($"The number of lowercase letters in your sentence is: {lowercaseCount}");
        }
    }
}
