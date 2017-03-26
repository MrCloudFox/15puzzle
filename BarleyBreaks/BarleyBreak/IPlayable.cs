using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarleyBreak
{
    interface IPlayable
    {
        void Randomize();
        bool IsFinished();
        void Shift(int value);
        double Side { get; }
        int this[int x, int y] { get; }
    }
}
