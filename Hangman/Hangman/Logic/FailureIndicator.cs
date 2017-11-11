using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Logic
{
    class FailureIndicator
    {
        private int _stage;

        public int Stage { get => _stage; set => _stage = value; }

        public void ShowRightStage(int which)
        {
            switch(which)
            {
                case 1:
                    Stage1();
                    break;
                case 2:
                    Stage2();
                    break;
                case 3:
                    Stage3();
                    break;
                case 4:
                    Stage4();
                    break;
                case 5:
                    Stage5();
                    break;
                case 6:
                    Stage6();
                    break;
                case 7:
                    Stage7();
                    break;
                case 8:
                    Stage8();
                    break;
                case 9:
                    Stage9();
                    break;
                case 10:
                    Stage10();
                    break;
            }
        }

        public void Stage1()
        {
            Console.WriteLine
                (
                    "           \n" +
                    "           \n" +
                    "           \n" +
                    "           \n" +
                    "  /\\       \n"
                );
        }
        public void Stage2()
        {
            Console.WriteLine
                (
                    "           \n" +
                    "           \n" +
                    "           \n" +
                    "   |        \n" +
                    "  /\\       \n"
                );
        }
        public void Stage3()
        {
            Console.WriteLine
                (
                    "           \n" +
                    "           \n" +
                    "   |       \n" +
                    "   |        \n" +
                    "  /\\       \n"
                );
        }
        public void Stage4()
        {
            Console.WriteLine
                (
                    "           \n" +
                    "    _       \n" +
                    "   |       \n" +
                    "   |        \n" +
                    "  /\\       \n"
                );
        }
        public void Stage5()
        {
            Console.WriteLine
                (
                    "           \n" +
                    "    _ _      \n" +
                    "   |       \n" +
                    "   |        \n" +
                    "  /\\       \n"
                );

        }
        public void Stage6()
        {
            Console.WriteLine
                (
                    "           \n" +
                    "    _ _      \n" +
                    "   |   |     \n" +
                    "   |        \n" +
                    "  /\\       \n"
                );

        }
        public void Stage7()
        {
            Console.WriteLine
                (
                    "           \n" +
                    "    _       \n" +
                    "   |        \n" +
                    "   |        \n" +
                    "  /\\       \n"
                );

        }
        public void Stage8()
        {

        }
        public void Stage9()
        {

        }
        public void Stage10()
        {

        }

    }
}
