using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Calc
{
    enum EState
    {
        OFF,
        ON
    }
    static class Memory
    {
        public static PNumber Number { get; set; }

        public static EState State { get; set; } = EState.OFF;

        static Memory()
        {
            Number = new PNumber("0");
        }

        public static PNumber Add(PNumber number)
        {
            Number += number;
            return new PNumber(Number.Number, Number.NumSystem);
        }

        public static PNumber Sub(PNumber number)
        {
            Number -= number;
            return new PNumber(Number.Number, Number.NumSystem);
        }

        public static void Clear()
        {
            Number = new PNumber("0");
            State = EState.OFF;
        }

            
    }
}
