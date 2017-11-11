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
            //string choosedLetter;
            //choosedLetter = Convert.ToString(Console.ReadKey().KeyChar);
            //Console.WriteLine(choosedLetter);
            //Console.ReadLine();
            var r = new Round();
            r.BeginAndAskForKeyword();
            Console.Clear();
            r.BeginGuessingStage();

            Console.ReadKey();
        }
    }
}
