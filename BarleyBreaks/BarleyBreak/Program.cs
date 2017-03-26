using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BarleyBreak
{
    class Program
    {
        static void Main(string[] args)
        {

            //var FieldOfGame = Game3.FromCSV("test2.csv");
            var FieldOfGame = new Game2(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 0, 15);
            IPlayable Iplayable = (IPlayable)FieldOfGame;

            var ConsoleGameUi = new ConsoleGameUI(Iplayable);

            ConsoleGameUi.Play();

        }


    }
}