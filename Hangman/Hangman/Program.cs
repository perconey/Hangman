using Hangman.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            var kb = new ConsoleKeyboard();
            kb.Display();

            Console.ReadKey();
        }
    }
}
