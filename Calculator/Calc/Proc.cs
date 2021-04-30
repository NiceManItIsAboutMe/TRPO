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
        Sum=24,
        Mult=26,
        Sub=25,
        Div=27,
        Sqr=20,
        Sqrt=21,
        Rec=22

    }
    class Proc
    {
        public PNumber Num1 { get; set; }
        public PNumber Num2 { get ; set; }
       // public PNumber Result { get ; set; }

        public EOperation Operation { get; set; } = EOperation.None;


        public Proc()
        {
            Num1 = new PNumber("0");
            Num2 = new PNumber("0");
          //  Result = new PNumber("0");
        }

        public void SwitchOperation(int tag)
        {
            if (tag == 24)
                Operation = EOperation.Sum;
            else if (tag == 25)
            {
                Operation = EOperation.Sub;
            }
            else if (tag == 26)
            {
                Operation = EOperation.Mult;
            }
            else if (tag == 27)
            {
                Operation = EOperation.Div;
            }
            
            
        }

        public void Clear()
        {
            Operation = EOperation.None;
            Num1 = new PNumber("0");
            Num2 = new PNumber("0");
           // Result = new PNumber("0");
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
                default:
                    return Num1;
            }
        }

        
    }
}
