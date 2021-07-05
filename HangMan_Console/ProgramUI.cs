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
        private readonly Gallows _gallow = new Gallows();
        private List<string> _guessedStrings = new List<string>();
        char[] answerArray;
        int score = 1;

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Welcome to HANGMAN, press any key to start!");
            Console.ReadKey();
            Console.Clear();
            _repo.ChoseWord();
            string randomWord = _repo.GetWord();
            int wordLength = randomWord.Length;
            
            answerArray = CreateAnswerArray(wordLength);
            while (isRunning)
            {
                Console.Clear();
                DisplayGameMenu(randomWord,answerArray,wordLength);
            }

        }
        public void DisplayGameMenu(string randomWord, char[] answerArray, int wordLength)
        {
            switch (score)
            {
                case 1:
                    _gallow.PrintGameInstructions();
                    _gallow.PrintManOne();
                    ExecuteGame(wordLength, randomWord);
                    break;
                case 2:
                    _gallow.PrintGameInstructions();
                    _gallow.PrintManTwo();
                    ExecuteGame(wordLength, randomWord);
                    break;
                case 3:
                    _gallow.PrintGameInstructions();
                    _gallow.PrintManThree();
                    ExecuteGame(wordLength, randomWord);
                    break;
                case 4:
                    _gallow.PrintGameInstructions();
                    _gallow.PrintManFour();
                    ExecuteGame(wordLength, randomWord);
                    break;
                case 5:
                    _gallow.PrintGameInstructions();
                    _gallow.PrintManFive();
                    ExecuteGame(wordLength, randomWord);
                    break;
                case 6:
                    _gallow.PrintGameInstructions();
                    _gallow.PrintManSix();
                    ExecuteGame(wordLength, randomWord);
                    break;
                case 7:
                    _gallow.PrintManSeven(randomWord);
                    isRunning = false;
                    
                    break;
                default:
                    break;
            }

        }
        private void ExecuteGame(int wordLength,string randomWord)
        {
            _gallow.PrintGuessLine(wordLength, answerArray, _guessedStrings);
            if (!CheckGuess(randomWord, GetInput()))
            {
                score++;
            }
        }
        private string GetInput()
        {
            string guessString = Console.ReadLine().ToLower();
            if (guessString.Length == 0)
            {
                Run();
            }
            return guessString;
        }
        private bool CheckGuess(string randomWord, string guessString)
        {
            bool check = false;
            bool correctGuess = AddToAnswerArray(randomWord, guessString);
            if (CharArrayToString(answerArray) == randomWord)
            {
                _gallow.PrintWinScreen(randomWord);
                isRunning = false;
                check = true;
                return check;
            }
            else if (PreviousGuess(guessString))
            {
                Console.Clear();
                Console.WriteLine($"Looks like you already guessed " + guessString + ", go back and try again.");
                Console.ReadKey();
                check = true;
                return check;
            }
            else if (correctGuess)
            {
                check = true;
            }
            return check;
        }
        private bool AddToAnswerArray(string randomWord, string guessString)
        {
            bool check = false;
            if (guessString.Length > 1)
            {
                if (guessString == randomWord)
                {
                    answerArray = StringToCharArray(guessString);
                    check = true;
                    return check;

                }
            }
            else
            {
                int letterCount = 0;
                char guessChar = char.Parse(guessString);
                char[] randomWordArray = StringToCharArray(randomWord);
                foreach (char c in randomWordArray)
                {
                    if (guessChar == c)
                    {
                        letterCount++;
                        answerArray[letterCount - 1] = guessChar;
                        check = true;
                    }
                    else
                    {
                        letterCount++;
                    }
                }
            }
            return check;
        }
        private bool PreviousGuess(string guess)
        {
            bool check = false;
            foreach (string guessString in _guessedStrings)
            {
                if (guessString == guess)
                {
                    check = true;
                    return check;
                }
            }
            _guessedStrings.Add(guess);
            return check;
        }
        private string CharArrayToString(char[] stringArray)
        {
            string newString = new string(stringArray);
            return newString;
        }
        private char[] StringToCharArray(string wordToConvert)
        {
            char[] wordCharArray = wordToConvert.ToCharArray();
            return wordCharArray;

        }
        private char[] CreateAnswerArray(int length)
        {
            char[] answerArray = new char[length];
            for (int i = 0; i < length; i++)
            {
                answerArray[i] = '_';
            }
            return answerArray;
        }






    }
}
