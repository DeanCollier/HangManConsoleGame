using HangMan_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    class ProgramUI
    {
        private bool isRunning = true;
        private readonly WordRepo _repo = new WordRepo();

        public void Run()
        {
            while (isRunning)
            {
                Console.WriteLine("Welcome to HANGMAN, press any key to start!");
                Console.ReadKey();
                string randomWord = _repo.GetWord();
                char[] randomWordArray = StringToCharArray(randomWord);
                char[] answerArray = CreateAnswerArray(randomWord);


            }

        }
        private char[] StringToCharArray(string wordToConvert)
        {
            char[] wordCharArray = wordToConvert.ToCharArray();
            return wordCharArray;
            
        }
        private char[] CreateAnswerArray(string randomWord)
        {
            char[] answerArray = new char[randomWord.Length];
            for (int i = 0; i < randomWord.Length; i++)
            {
                answerArray[i] = '_';
            }
            return answerArray;
        }



    }
}
