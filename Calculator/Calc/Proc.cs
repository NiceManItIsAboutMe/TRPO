using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Calc
{
    enum EOperation: Int32
    {
        None,
        Sum=21,
        Mult=23,
        Sub=22,
        Div=24,
        Sqr=25,
        Sqrt=26,
        Rec=27,
        Equal=28

    }
    class Proc
    {
        public PNumber Num1 { get; set; }
        public PNumber Num2 { get ; set; }

        public EOperation Operation { get; set; } = EOperation.None;


        public Proc()
        {
            Num1 = new PNumber("0");
            Num2 = new PNumber("0");
        }

        public void Clear()
        {
            Operation = EOperation.None;
            Num1 = new PNumber("0");
            Num2 = new PNumber("0");
        }

        public PNumber DoOperation()
        {
            switch (Operation)
            {
                case EOperation.Sum:
                    return Num1 += Num2;
                case EOperation.Sub:
                    return Num1 -= Num2;
                case EOperation.Mult:
                    return Num1 *= Num2;
                case EOperation.Div:
                    return Num1 /= Num2;
                case EOperation.Sqr:
                    return Num1=PNumber.Sqr(Num1);
                case EOperation.Sqrt:
                    return Num1=PNumber.Sqrt(Num1);
                case EOperation.Rec:
                    return Num1=PNumber.Reciprocal(Num1);
                default:
                    return Num1;
            }
        }

        
    }
}
