using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Logic
{
    class Round
    {
        private String _keyWord;
        private ConsoleKeyboard _vKey = new ConsoleKeyboard();

        internal ConsoleKeyboard VKey { get => _vKey; set => _vKey = value; }
        public string KeyWord { get => _keyWord; set => _keyWord = value; }

        public Round()
        {

        }

        public void BeginGuessingStage()
        {
            string choosedLetter;
            do
            {
                Console.WriteLine("You have following letters available to use:");
                VKey.Display();

                choosedLetter = Convert.ToString(Console.ReadKey().KeyChar);



            } while (true);
        }

        public void BeginAndAskForKeyword()
        {
            Console.WriteLine("Welcome to Console Hangman! \n" +
                " Enter keyword to be guessed below:");
            KeyWord = Console.ReadLine();
        }

    }
}
