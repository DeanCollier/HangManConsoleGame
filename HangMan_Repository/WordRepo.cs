using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Repository
{
     public class WordRepo
    {
        private readonly Word _word = new Word();
        
        //create
        public bool ChoseWord()
        {
            var random = new Random();
            int randomNumber = random.Next(1, 100);
            _word.WordChoice = (WordOption)randomNumber;
            return (_word.WordChoice.ToString().Length != 0);
        }
        //read
        public string GetWord() => _word.WordChoice.ToString();
        
    }
}
