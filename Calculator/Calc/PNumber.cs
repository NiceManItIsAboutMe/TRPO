using Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Calc
{

    class PNumber 
    {
        private string number;

        private double number10;

        private int numSystem;

        private int accuracy;


        public string Number { get { return number; } 
            set {
                number = value;
                while(number.Contains(".")&&number.EndsWith("0"))
                {
                    number = number.Substring(0, number.Length - 1);
                }
                this.number10 = Conver_P_10.Do(number, numSystem);
                    } }

        public double DecimalNum => number10;

        public int NumSystem => numSystem;

        public PNumber(PNumber num)//создает копию числа
        {
            this.Number = num.Number;
            this.numSystem = num.numSystem;
            this.accuracy = num.accuracy;
            this.number10 = num.number10;
        }
       /* public PNumber(double number, int numSystem=10, int accuracy=10)
        {
            this.number = number;
            this.numSystem = numSystem;
            this.accuracy = accuracy;
            this.Number = number.ToString();
        }*/

        public PNumber(string numberStr, int numSystem = 10, int accuracy = 10)
        {
            this.Number = numberStr;
            this.numSystem = numSystem;
            this.accuracy = accuracy;

            this.number10 = Conver_P_10.Do(numberStr, numSystem);
        }

        public static PNumber operator +(PNumber num1, PNumber num2)
        {
            return new PNumber(Conver_10_P.Do(num1.number10 + num2.number10, num1.numSystem,num1.accuracy), num1.numSystem,num1.accuracy);
        }

        public static PNumber operator -(PNumber num1, PNumber num2)
        {
            return new PNumber(Conver_10_P.Do(num1.number10 - num2.number10, num1.numSystem, num1.accuracy), num1.numSystem, num1.accuracy);
        }

        public static PNumber operator *(PNumber num1, PNumber num2)
        {
            return new PNumber(Conver_10_P.Do(num1.number10 * num2.number10, num1.numSystem, num1.accuracy), num1.numSystem, num1.accuracy);
        }
        public static PNumber operator /(PNumber num1, PNumber num2)
        {
            return new PNumber(Conver_10_P.Do(num1.number10 / num2.number10, num1.numSystem, num1.accuracy), num1.numSystem, num1.accuracy);
        }

        public static PNumber Reciprocal(PNumber num1)
        {
            return new PNumber(Conver_10_P.Do(1/num1.number10, num1.numSystem, num1.accuracy), num1.numSystem, num1.accuracy);
        }

        public static PNumber Sqr(PNumber num1)
        {
            return new PNumber(Conver_10_P.Do(num1.number10 * num1.number10, num1.numSystem, num1.accuracy), num1.numSystem, num1.accuracy);
        }

        public static PNumber Sqrt(PNumber num1)
        {
            return new PNumber(Conver_10_P.Do(Math.Sqrt(num1.number10), num1.numSystem, num1.accuracy), num1.numSystem, num1.accuracy);
        }

        public string ChangeNumSystem(int numSystem)
        {
            this.numSystem = numSystem;
            this.Number = Conver_10_P.Do(this.number10, this.numSystem,this.accuracy);
            return Number;
        }
    }
}
