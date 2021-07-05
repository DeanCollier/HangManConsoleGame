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
            Console.WriteLine(randomWord);
            string guess;
            switch (score)
            {
                case 1:
                    _gallow.PrintManOne();
                    _gallow.PrintGuessLine(wordLength, answerArray, _guessedStrings);
                    if (CheckGuess(randomWord))
                    {
                        break;
                    }
                    else
                    {
                        score++;
                    }
                    break;
                case 2:
                    _gallow.PrintManTwo();
                    _gallow.PrintGuessLine(wordLength, answerArray, _guessedStrings);
                    if (CheckGuess(randomWord))
                    {
                        break;
                    }
                    else
                    {
                        score++;
                    }
                    break;
                case 3:
                    _gallow.PrintManThree();
                    _gallow.PrintGuessLine(wordLength, answerArray, _guessedStrings);
                    if (CheckGuess(randomWord))
                    {
                        break;
                    }
                    else
                    {
                        score++;
                    }
                    break;
                case 4:
                    _gallow.PrintManFour();
                    _gallow.PrintGuessLine(wordLength, answerArray, _guessedStrings);
                    if (CheckGuess(randomWord))
                    {
                        break;
                    }
                    else
                    {
                        score++;
                    }
                    break;
                case 5:
                    _gallow.PrintManFive();
                    _gallow.PrintGuessLine(wordLength, answerArray, _guessedStrings);
                    if (CheckGuess(randomWord))
                    {
                        break;
                    }
                    else
                    {
                        score++;
                    }
                    break;
                case 6:
                    _gallow.PrintManSix();
                    _gallow.PrintGuessLine(wordLength, answerArray, _guessedStrings);
                    if (CheckGuess(randomWord))
                    {
                        break;
                    }
                    else
                    {
                        score++;
                    }
                    break;
                case 7:
                    _gallow.PrintManSeven();
                    
                    break;
                default:
                    break;
            }

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
        private bool CheckGuess(string randomWord)
        {
            if (CharArrayToString(answerArray) == randomWord)
            {
                _gallow.PrintWinScreen();
                isRunning = false;
                return true;
            }
            string guessString = Console.ReadLine().ToLower();
            bool check = false;
            if (PreviousGuess(guessString))
            {
                return true;
            }
            if (guessString.Length > 1)
            {
                if (guessString == randomWord)
                {
                    _gallow.PrintWinScreen();
                    isRunning = false;
                    check = true;
                    return check;
                }
                else
                {
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
                return check;

            }
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

        //private char[] UpdateAnswerArray(char guess, char[] answerArray, List<char> guessedLetters)
        //{

        //}
        //private List<char> UpdateGuessedLetters()



    }
}
