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

        public string Number { get; set; } = "0";

        bool isZero = true;

        public string AddDigit(int tag)
        {
            if (isZero)
            {
                if (tag < 10)
                    Number = tag.ToString();
                else if (tag == 10)
                    Number = "A";
                else if (tag == 11)
                    Number = "B";
                else if (tag == 12)
                    Number = "C";
                else if (tag == 13)
                    Number = "D";
                else if (tag == 14)
                    Number = "E";
                else if (tag == 15)
                    Number = "F";
            }
            else
            {

                if (tag < 10)
                    Number += tag.ToString();
                else if (tag == 10)
                    Number += "A";
                else if (tag == 11)
                    Number += "B";
                else if (tag == 12)
                    Number += "C";
                else if (tag == 13)
                    Number += "D";
                else if (tag == 14)
                    Number += "E";
                else if (tag == 15)
                    Number += "F";
            }
            isZero = false;
            return Number;
        }

        public string AddZero()
        {
            if (!isZero)
                Number += ZERO;
            return Number;
                
        }

        public string AddDelimeter()
        {
            if (!Number.Contains(DELIMITER))
                Number += DELIMITER;
            isZero = false;
            return Number;
        }

        public string Clear()
        {
            Number = ZERO;
            isZero = true;
            return Number;
        }

        public string AddSign()
        {
            if(Number!="0")
            if (Number.Contains("-"))
                Number = Number.Substring(1);
            else
                Number = "-" + Number;
            return Number;
        }

        public string DeleteSymbol()
        {
            if (Number.Length == 1)
                return Clear();
            if (!isZero)
                Number = Number.Substring(0, Number.Length - 1);
            return Number;
        }
        public string DoEdit(int tag)
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
