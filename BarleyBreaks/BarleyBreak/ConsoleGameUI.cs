using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarleyBreak
{
    class ConsoleGameUI
    {
        IPlayable Iplayable;

        public ConsoleGameUI(IPlayable Iplayable)
        {
            this.Iplayable = Iplayable;
        }

        public void Play()
        {
            

            int EnterFromUser, AmountStepsOfGame;
            bool ControlMenu = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Enter the number which you want to move.\n");
                Console.WriteLine("Enter -1 to shake values.\n");
                //Console.WriteLine("Enter -2 to see history.\n");
                //Console.WriteLine("Enter -3 to FlashBack.\n");
                Console.WriteLine("Enter 0 to leave.\n");
                OutPutMatrix();
                if (Iplayable.IsFinished()) Console.WriteLine("You WIN!!!");

                EnterFromUser = int.Parse(Console.ReadLine());
                switch (EnterFromUser)
                {
                    case 0:
                        ControlMenu = true;
                        Console.Beep();
                        break;

                    case -1:
                        Iplayable.Randomize();
                        break;

                    /*case -2:
                        for (int i = 0; i < FieldOfGame.GetHistory.Count; i++)
                        {
                            Console.WriteLine("Value " + FieldOfGame.GetHistory[i].value +
                                " we moved on " + FieldOfGame.GetHistory[i].valueX + " " + FieldOfGame.GetHistory[i].valueY);
                        }
                        Console.WriteLine("Enter any key to continue.");
                        Console.ReadKey();
                        break;

                    case -3:
                        Console.WriteLine("How many steps you want roll back?");
                        AmountStepsOfGame = int.Parse(Console.ReadLine());
                        FieldOfGame.FlashBackOnStep(AmountStepsOfGame);
                        break;*/

                    default:
                        Iplayable.Shift(EnterFromUser);
                        Console.Beep();
                        break;

                }

            } while (!ControlMenu);
        }


        public void OutPutMatrix()
        {
    

            for (int i = 0; i < Iplayable.Side; i++)
            {
                for (int j = 0; j < Iplayable.Side; j++)
                {
                    Console.Write(String.Format("{0,2} ", Iplayable[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
