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
        private int _underscoreMarksCounter = 0;
        private bool _winnerWinnerChickenDinner = false;
        private FailureIndicator failure = new FailureIndicator();
        
        internal ConsoleKeyboard VKey { get => _vKey; set => _vKey = value; }
        public string KeyWord { get => _keyWord;
            set
            {
                _keyWord = value.ToLower();
                foreach(char c in _keyWord)
                {
                    UnderscoreMarksCounter++;
                    Chars.Add(new KeyValuePair<char, bool>(c, false));
                }
            }
        }

        public List<KeyValuePair<char, bool>> Chars
        {
            get => _chars;
            set => _chars = value;
        }
        public bool WinnerWinnerChickenDinner { get => _winnerWinnerChickenDinner; set => _winnerWinnerChickenDinner = value; }
        public int UnderscoreMarksCounter { get => _underscoreMarksCounter; set => _underscoreMarksCounter = value; }

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
                Console.WriteLine("\t\tYour guessing progress:");
                Console.Write("\n");
                Console.Write("\t\t  "); ShowUnderscoreBuild();
                Console.Write("\n");
                failure.ShowRightStage(failure.Stage);


                Console.WriteLine("For guessing letter choose 1, for guessing word press 2");
                try
                {
                    option = Convert.ToInt16(Console.ReadLine());
                }catch(Exception ex)
                {
                    Console.WriteLine("Bad input! Choosing 1");
                    option = 1;
                }

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
                            bool isEmpty = !w.Any();
                            if(!isEmpty)
                            {
                                foreach (int which in w)
                                {
                                    Chars[which] = new KeyValuePair<char, bool>(Convert.ToChar(choosedLetter), true);
                                UnderscoreMarksCounter--;
                                }
                            }
                            else
                            {
                                failure.BadGuessMade();
                            }

                        break;
                        case 2:
                            Console.WriteLine("Type word below:");
                            guessedWord = Console.ReadLine();
                            if(guessedWord == KeyWord)
                            {
                                Console.WriteLine("YOU GUESSED");
                                WinnerWinnerChickenDinner = true;
                                styknie = true;
                            }
                        else
                        {
                            failure.BadGuessMade();
                        }
                            break;
                    }

                if(failure.Stage == 11)
                {
                    styknie = true;
                }

                if(UnderscoreMarksCounter == 0)
                {
                    styknie = true;
                    WinnerWinnerChickenDinner = true;
                }
                Console.Clear();
            } while (!styknie);
            if(WinnerWinnerChickenDinner)
            {
                Console.WriteLine("YOU WON!");
            }
            else
            {
                Console.WriteLine("YOU LOST!");
            }
            Console.WriteLine("Press any key to play one more time");
            Console.ReadKey();
            Console.Clear();
            Reset();

        }

        public void Reset()
        {
            UnderscoreMarksCounter = 5;
            VKey.Reset();
            WinnerWinnerChickenDinner = false;
            Chars.Clear();
            failure.Reset();
            BeginAndAskForKeyword(); 
        }
        public void BeginAndAskForKeyword()
        {
            Console.WriteLine("Welcome to Console Hangman! \n" +
                " Enter keyword to be guessed below:");
            KeyWord = Console.ReadLine();
            Console.Clear();
            BeginGuessingStage();
        }

    }
}
