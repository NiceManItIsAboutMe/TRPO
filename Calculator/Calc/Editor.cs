using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Calc
{

    class Editor
    {
        private readonly string ZERO = "0";
        private readonly string DELIMITER = ".";

        public PNumber Number { get; set; } = new PNumber("0");

        bool isZero = true;

        public PNumber AddDigit(int tag)
        {
            if (isZero)
            {
                if (tag < 10)
                    Number.Number = tag.ToString();
                else if (tag == 10)
                    Number.Number = "A";
                else if (tag == 11)
                    Number.Number = "B";
                else if (tag == 12)
                    Number.Number = "C";
                else if (tag == 13)
                    Number.Number = "D";
                else if (tag == 14)
                    Number.Number = "E";
                else if (tag == 15)
                    Number.Number = "F";
            }
            else
            {

                if (tag < 10)
                    Number.Number += tag.ToString();
                else if (tag == 10)
                    Number.Number += "A";
                else if (tag == 11)
                    Number.Number += "B";
                else if (tag == 12)
                    Number.Number += "C";
                else if (tag == 13)
                    Number.Number += "D";
                else if (tag == 14)
                    Number.Number += "E";
                else if (tag == 15)
                    Number.Number += "F";
            }
            isZero = false;
            return Number;
        }

        public PNumber AddZero()
        {
            if (!isZero)
                Number.Number += ZERO;
            return Number;
                
        }

        public PNumber AddDelimeter()
        {
            if (!Number.Number.Contains(DELIMITER))
                Number.Number += DELIMITER;
            isZero = false;
            return Number;
        }

        public PNumber Clear()
        {
            Number.Number = ZERO;
            isZero = true;
            return Number;
        }

        public PNumber AddSign()
        {
            if(Number.Number!="0")
            if (Number.Number.Contains("-"))
                Number.Number = Number.Number.Substring(1);
            else
                Number.Number = "-" + Number.Number;
            return Number;
        }

        public PNumber DeleteSymbol()
        {
            if (Number.Number.Length == 1)
                return Clear();
            if (!isZero)
                Number.Number = Number.Number.Substring(0, Number.Number.Length - 1);
            return Number;
        }
        public PNumber DoEdit(int tag)
        {
            if (tag == 0) return AddZero();
            if (tag <= 15 && tag!=0) return AddDigit(tag);
            if (tag == 16) return AddDelimeter();
            if (tag == 17) return DeleteSymbol();
            if (tag == 18) return Clear();
            if (tag == 19) return AddSign();
            return Number;
        }

    }
}
