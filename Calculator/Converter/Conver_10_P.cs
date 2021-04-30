using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class Conver_10_P
    {
        public static string Do(double n, int p, int c=7)
        {
            if (n == 0)
                return "0";
            string res = "";
            res += IntToP((int)(n - (n % 1)), p) + FltToP(Math.Abs(n % 1), p, c);
            return res;
        }
        public static char IntToChar(int n)
        {
            switch (n)
            {
                case 0:
                    return '0';
                case 1:
                    return '1';
                case 2:
                    return '2';
                case 3:
                    return '3';
                case 4:
                    return '4';
                case 5:
                    return '5';
                case 6:
                    return '6';
                case 7:
                    return '7';
                case 8:
                    return '8';
                case 9:
                    return '9';
                case 10:
                    return 'A';
                case 11:
                    return 'B';
                case 12:
                    return 'C';
                case 13:
                    return 'D';
                case 14:
                    return 'E';
                case 15:
                    return 'F';
                //default:
                   // throw new Exception("Недопустимый символ");
            }
            return new char();
        }
        
        public static string IntToP(int n, int p)
        {
            string res="";
            string sign = "";
            if (n == int.MinValue)
                throw new Exception("Вы ввели слишком большое число");
            if (n < 0)
            {
                n = -n;
                sign = "-";
            }
            if (n == 0)
                res = "0";
            while(n!=0)
            {
                res += IntToChar(n % p);
                n /= p;
            }
            char[] input = res.ToCharArray();
            Array.Reverse(input);
            res = new string(input);
            res = sign + res;
            return res;
        }

        public static string FltToP(double n,int p, int c)
        {
            string res = "";
            while (n % 1 != 0 && c>0)
            {
                --c;
                n *= p;
                res += IntToChar((int)(n - (n % 1)));
                n %= 1;
            }
            if (res.Length != 0)
                res = "." + res;
            return res;
        }
    }
}
