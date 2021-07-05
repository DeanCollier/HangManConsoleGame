using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    public class Gallows
    {
        public void PrintManOne()
        {
            Console.WriteLine("           +==========+\n" +
                              "           |          |\n" +
                              "           |          |\n" +
                              "           |           \n" +
                              "           |           \n" +
                              "           |           \n" +
                              "           |           \n" +
                              "           |           \n" +
                              "__________*|*__________\n");
        
        }
        public void PrintManTwo()
        {
            Console.WriteLine("           +==========+\n" +
                              "           |          |\n" +
                              "           |          |\n" +
                              "           |          O\n" +
                              "           |           \n" +
                              "           |           \n" +
                              "           |           \n" +
                              "           |           \n" +
                              "__________*|*__________\n");

        }
        public void PrintManThree()
        {
            Console.WriteLine("           +==========+\n" +
                              "           |          |\n" +
                              "           |          |\n" +
                              "           |          O\n" +
                              "           |          |\n" +
                              "           |          |\n" +
                              "           |           \n" +
                              "           |           \n" +
                              "__________*|*__________\n");

        }
        public void PrintManFour()
        {
            Console.WriteLine("           +==========+\n" +
                              "           |          |\n" +
                              "           |          |\n" +
                              "           |          O\n" +
                              "           |        >-|\n" +
                              "           |          |\n" +
                              "           |           \n" +
                              "           |           \n" +
                              "__________*|*__________\n");

        }
        public void PrintManFive()
        {
            Console.WriteLine("           +==========+\n" +
                              "           |          |\n" +
                              "           |          |\n" +
                              "           |          O\n" +
                              "           |        >-|-<\n" +
                              "           |          |\n" +
                              "           |           \n" +
                              "           |           \n" +
                              "__________*|*__________\n");

        }
        public void PrintManSix()
        {
            Console.WriteLine("           +==========+\n" +
                              "           |          |\n" +
                              "           |          |\n" +
                              "           |          O\n" +
                              "           |        >-|-<\n" +
                              "           |          |\n" +
                              "           |         ( \n" +
                              "           |           \n" +
                              "__________*|*__________\n");

        }
        public void PrintManSeven(string randomWord)
        {
            Console.WriteLine("           +==========+\n" +
                              "           |          |\n" +
                              "           |          |\n" +
                              "           |          O\n" +
                              "           |        >-|-<\n" +
                              "           |          |\n" +
                              "           |         ( )\n" +
                              "           |           \n" +
                              "__________*|*__________\n");
            Console.WriteLine("Sorry, looks like you're all out of guesses :(");
            Console.WriteLine($"The word was: " + randomWord);
            Console.ReadKey();
        }
        public void PrintGuessLine(int wordLength, char[] answerArray, List<string> previousGuesses)
        {
            string answer = new string(answerArray);
            Console.WriteLine($"The word has " + wordLength + " letters: " + answer);
            PrintPreviousGuesses(previousGuesses);
            Console.Write("Please guess a letter or the entire word: ");
            
        }

        public void PrintWinScreen(string randomWord)
        {
            Console.Clear();
            Console.WriteLine("Congrats! You guessed the word correctly!");
            Console.WriteLine($"The word was: " + randomWord);
            Console.ReadKey();
        }
        
        public void PrintPreviousGuesses(List<string> previousGuesses)
        {
            string guesses = string.Join(",", previousGuesses);
            Console.WriteLine($"Previous guesses: " + guesses); 
        }
    }
}
