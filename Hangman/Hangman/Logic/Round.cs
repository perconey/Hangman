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
        private List<KeyValuePair<char, bool>> _chars = new List<KeyValuePair<char, bool>>();


        internal ConsoleKeyboard VKey { get => _vKey; set => _vKey = value; }
        public string KeyWord { get => _keyWord;
            set
            {
                _keyWord = value.ToLower();
                foreach(char c in _keyWord)
                {
                    Chars.Add(new KeyValuePair<char, bool>(c, false));
                }
            }
        }

        public List<KeyValuePair<char, bool>> Chars
        {
            get => _chars;
            set => _chars = value;
        }

        public int AwfulCharToNumConverter(char c)
        {
            int ret;
            switch(c)
            {
                case 'q':
                    ret = 0;
                    break;
                case 'w':
                    ret = 1;
                    break;
                case 'e':
                    ret = 2;
                    break;
                case 'r':
                    ret = 3;
                    break;
                case 't':
                    ret = 4;
                    break;
                case 'y':
                    ret = 5;
                    break;
                case 'u':
                    ret = 6;
                    break;
                case 'i':
                    ret = 7;
                    break;
                case 'o':
                    ret = 8;
                    break;
                case 'p':
                    ret = 9;
                    break;
                case 'a':
                    ret = 11;
                    break;
                case 's':
                    ret = 12;
                    break;
                case 'd':
                    ret = 13;
                    break;
                case 'f':
                    ret = 14;
                    break;
                case 'g':
                    ret = 15;
                    break;
                case 'h':
                    ret = 16;
                    break;
                case 'j':
                    ret = 17;
                    break;
                case 'k':
                    ret = 18;
                    break;
                case 'l':
                    ret = 19;
                    break;
                case 'z':
                    ret = 21;
                    break;
                case 'x':
                    ret = 22;
                    break;
                case 'c':
                    ret = 23;
                    break;
                case 'v':
                    ret = 24;
                    break;
                case 'b':
                    ret = 25;
                    break;
                case 'n':
                    ret = 26;
                    break;
                case 'm':
                    ret = 27;
                    break;
                default:
                    ret = 666;
                    break;

            }
            return ret;
        }

        public Round()
        {

        }

        public void ShowUnderscoreBuild()
        {
            foreach(var el in Chars)
            {
                if(el.Value == false)
                {
                    Console.Write("_ ");
                }
                else
                {
                    Console.Write(el.Key + " ");
                }
            }
        }

        public void BeginGuessingStage()
        {
            string choosedLetter, guessedWord;
            int option;
            bool styknie = false;
            do
            {
                Console.WriteLine("Your guessing progress");
                Console.Write("\n");
                ShowUnderscoreBuild();
                Console.Write("\n");

                Console.WriteLine("For guessing letter choose 1, for guessing word press 2");
                   
                    option = Convert.ToInt16(Console.ReadLine());
                    if (option != 1 || option != 2)
                        option = 1;

                    switch (option)
                    {
                        case 1:
                            int i = 0;

                            Console.WriteLine("You have following letters available to use:");
                            VKey.Display();
                            choosedLetter = Convert.ToString(Console.ReadKey().KeyChar);
                            VKey.KeyboardChars[AwfulCharToNumConverter(Convert.ToChar(choosedLetter))] = new KeyValuePair<char, bool>(Convert.ToChar(choosedLetter), true);
                            Console.WriteLine("\n");
                            var w = new List<int>();

                            foreach(var el in Chars)
                            {
                                if (el.Key == Convert.ToChar(choosedLetter))
                                {
                                    w.Add(i);
                                i++;
                                }
                                else
                                {
                                i++;
                                }
                            }

                            foreach(int which in w)
                            {
                            Console.WriteLine(which);
                                Chars[which] = new KeyValuePair<char, bool>(Convert.ToChar(choosedLetter), true);
                            }

                        break;
                        case 2:
                            Console.WriteLine("Type word below:");
                            guessedWord = Console.ReadLine();
                            if(guessedWord == KeyWord)
                            {
                                Console.WriteLine("YOU GUESSED");
                                styknie = true;
                            }
                            break;
                    }


                Console.Clear();
            } while (!styknie);
        }

        public void BeginAndAskForKeyword()
        {
            Console.WriteLine("Welcome to Console Hangman! \n" +
                " Enter keyword to be guessed below:");
            KeyWord = Console.ReadLine();
        }

    }
}
