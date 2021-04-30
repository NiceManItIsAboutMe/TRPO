using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class Conver_P_10
    {
        public static double Do(string p_num, int p)
        {
            if (p_num == "0")
                return 0;
            string intNum = p_num;
            string fractional = "0";
            int i = 0;
            double res = 0;
            double sign = 1;
            if (p_num.Contains('-'))
            {
                sign *= -1;
                p_num=p_num.Replace("-", "");
            }
            if (p_num.Contains('.'))
            {
                intNum = p_num.Split('.')[0];
                fractional = p_num.Split('.')[1];
            }
            if (p_num.Contains(','))
            {
                intNum = p_num.Split(',')[0];
                fractional = p_num.Split(',')[1];
            }
            while (i!=intNum.Length)
            {
                res+=CharToNum(intNum.Substring(i, 1))*Math.Pow(p,intNum.Length-i-1);
                ++i;
            }
            i = 0;
            while (i != fractional.Length)
            {
                res += CharToNum(fractional.Substring(i, 1)) * Math.Pow(p, -i - 1);
                ++i;
            }
            return res*sign;

        }
        public static double CharToNum(string str)
        {
            switch (str)
            {
                case "0":
                    return 0;
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "A":
                    return 10;
                case "B":
                    return 11;
                case "C":
                    return 12;
                case "D":
                    return 13;
                case "E":
                    return 14;
                case "F":
                    return 15;
                default:
                    return 0;
            }
           // return new double();
        }

    }
}
