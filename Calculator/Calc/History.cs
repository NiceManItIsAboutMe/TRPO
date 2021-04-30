using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Calc
{
    class HistoryItem
    {
        public  PNumber FirstNumber;
        public  EOperation Eoperation;
        public string Operation;
        public  PNumber SecondNumber;
        public  PNumber Result;
        public int numSystem;
        public HistoryItem(PNumber FirstNumber, EOperation Operation, PNumber SecondNumber, PNumber Result)
        {
            this.FirstNumber = FirstNumber;
            this.SecondNumber = SecondNumber;
            this.Eoperation = Operation;
            if (Eoperation == EOperation.Sum)
                this.Operation = "+";
            else if (Eoperation == EOperation.Sub)
                this.Operation = "-";
            else if (Eoperation == EOperation.Mult)
                this.Operation = "*";
            else if (Eoperation == EOperation.Div)
                this.Operation = "/";
            else if (Eoperation == EOperation.Sqr)
                this.Operation = "²";
            else if (Eoperation == EOperation.Sqrt)
                this.Operation = "√";
            else if (Eoperation == EOperation.Rec)
                this.Operation = "1/";
            this.Result = Result;
        }

    }
   class History
    {
        private List<HistoryItem> history = new List<HistoryItem>();

        public void AddHistoryItem(HistoryItem item) 
        {
            item.FirstNumber.ChangeNumSystem(10);
            item.SecondNumber.ChangeNumSystem(10);
            item.Result.ChangeNumSystem(10);
            history.Add(item);
        }

        public void Clear()
        {
            history.Clear();
        }

        public string ChangeNumSystem(int numSystem)
        {
            string res = "";
            if (history.Count != 0)
            {
                int i = 0;

                foreach (var item in history)
                {
                    item.FirstNumber.ChangeNumSystem(numSystem);
                    item.SecondNumber.ChangeNumSystem(numSystem);
                    item.Result.ChangeNumSystem(numSystem);
                    if (item.Eoperation == EOperation.Sum || item.Eoperation == EOperation.Sub || item.Eoperation == EOperation.Div || item.Eoperation == EOperation.Mult)
                        res += (++i) + ") " + item.FirstNumber.Number + " " + item.Operation + " " + item.SecondNumber.Number + " = " + item.Result.Number + " (" + item.FirstNumber.NumSystem + ") " + Environment.NewLine;
                    else if (item.Eoperation == EOperation.Sqr)
                        res += (++i) + ") " + item.FirstNumber.Number + item.Operation + " = " + item.Result.Number + " (" + item.FirstNumber.NumSystem + ") " + Environment.NewLine;
                    else
                        res += (++i) + ") " + item.Operation + item.FirstNumber.Number + " = " + item.Result.Number + " (" + item.FirstNumber.NumSystem + ") " + Environment.NewLine;
                }
            }
            else
                res = "История пуста";
            return res;
           
        }
        public string ViewText()
        {
            string res = "";
            if (history.Count != 0)
            {
                
                int i = 0;
                foreach (var item in history)
                {
                    if(item.Eoperation==EOperation.Sum|| item.Eoperation == EOperation.Sub|| item.Eoperation == EOperation.Div|| item.Eoperation == EOperation.Mult)
                    res += (++i) + ") " + item.FirstNumber.Number + " " + item.Operation + " " + item.SecondNumber.Number + " = " + item.Result.Number+" ("+item.FirstNumber.NumSystem+") "+Environment.NewLine;
                    else if(item.Eoperation==EOperation.Sqr)
                        res += (++i) + ") " + item.FirstNumber.Number + item.Operation + " = " + item.Result.Number + " (" + item.FirstNumber.NumSystem + ") " + Environment.NewLine;
                    else
                        res += (++i) + ") " + item.Operation + item.FirstNumber.Number + " = " + item.Result.Number + " (" + item.FirstNumber.NumSystem + ") " + Environment.NewLine;
                }
            }
            else
                res = "История пуста";
            return res;
        }

    }
}
