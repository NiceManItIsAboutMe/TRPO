using Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Calc
{
    class MyControl
    {
        public Editor editor=new Editor();

        public Proc proc = new Proc();

        public History history = new History();

        public EOperation Operation = EOperation.None;
        public int numSystem { get; set; } = 10;

        public string ChangeSystem(int numSystem)
        {
            editor.Number = Conver_10_P.Do(Conver_P_10.Do(editor.Number, this.numSystem), numSystem);
            this.numSystem = numSystem;
            proc.Num1.ChangeNumSystem(numSystem);
            proc.Num2.ChangeNumSystem(numSystem);
            return editor.Number;

        }
        public string DoCommand(int tag)
        {
       

            if (tag == 0)
            {
                Operation = EOperation.None;
                return editor.AddZero();
            }
            else if (tag <= 15)
                return editor.AddDigit(tag);
            else if (tag == 16)
                return editor.AddDelimeter();
            else if (tag == 17)
                return editor.AddSign();
            else if (tag == 18)
                return editor.DeleteSymbol();
            else if (tag == 19)
            {
                if (editor.Number == "0")
                    proc.Operation = EOperation.None;
                else
                {
                    if (Operation == EOperation.Equal)
                        proc.Clear();
                    return editor.Clear();
                }

                return editor.Number = proc.Num1.Number;
            }
            else if (tag == 20)
            {
                proc.Clear();
                return editor.Clear();
            }
            else if (tag == 21)
            {
                if (proc.Operation == EOperation.None)
                    proc.Num1 = new PNumber(editor.Number, numSystem);
                else if (proc.Operation != EOperation.None && editor.Number != "0")
                {
                    DoCommand(28);
                }

                proc.Operation = EOperation.Sum;
                return editor.Clear();
            }
            else if (tag == 22)
            {
                if (proc.Operation == EOperation.None)
                    proc.Num1 = new PNumber(editor.Number, numSystem);
                else if (proc.Operation != EOperation.None && editor.Number != "0")
                {
                    DoCommand(28);
                }
                proc.Operation = EOperation.Sub;
                return editor.Clear();
            }
            else if (tag == 23)
            {
                if (proc.Operation == EOperation.None)
                    proc.Num1 = new PNumber(editor.Number, numSystem);
                else if (proc.Operation != EOperation.None && editor.Number != "0")
                {
                    DoCommand(28);
                }
                proc.Operation = EOperation.Mult;
                return editor.Clear();
            }
            else if (tag == 24)
            {
                if (proc.Operation == EOperation.None)
                    proc.Num1 = new PNumber(editor.Number, numSystem);
                else if (proc.Operation != EOperation.None && editor.Number != "0")
                {
                    DoCommand(28);
                }
                proc.Operation = EOperation.Div;
                return editor.Clear();
            }
            else if (tag == 25)
            {
                //if (proc.Operation == EOperation.None)
                proc.Num1 = new PNumber(editor.Number, numSystem);
                proc.Operation = EOperation.Sqr;
                PNumber temp = proc.Num1;
                PNumber res = proc.DoOperation();
                history.AddHistoryItem(new HistoryItem(temp, proc.Operation, proc.Num2, res));
                proc.Operation = EOperation.None;
                return editor.Number = res.Number;
            }
            else if (tag == 26)
            {
                //if (proc.Operation == EOperation.None)
                proc.Num1 = new PNumber(editor.Number, numSystem);
                proc.Operation = EOperation.Sqrt;
                PNumber temp = proc.Num1;
                PNumber res = proc.DoOperation();
                proc.Operation = EOperation.None;

                history.AddHistoryItem(new HistoryItem(temp, proc.Operation, proc.Num2, res));

                return editor.Number = res.Number;
            }
            else if (tag == 27)
            {
                //if (proc.Operation == EOperation.None)
                proc.Num1 = new PNumber(editor.Number, numSystem);
                proc.Operation = EOperation.Rec;
                PNumber temp = proc.Num1;
                PNumber res = proc.DoOperation();
                proc.Operation = EOperation.None;

                history.AddHistoryItem(new HistoryItem(temp, proc.Operation, proc.Num2, res));

                return editor.Number = res.Number;
            }
            else if (tag == 28)
            {
                if (Operation != EOperation.Equal && editor.Number != "0")
                    proc.Num2 = new PNumber(editor.Number, numSystem);
                else if (editor.Number == "0")
                    proc.Num2 = proc.Num1;
                Operation = EOperation.Equal;
                if (proc.Operation == EOperation.None)
                    return editor.Number;

                PNumber temp = proc.Num1;
                PNumber res = proc.DoOperation();

                history.AddHistoryItem(new HistoryItem(temp, proc.Operation, new PNumber(proc.Num2.Number, proc.Num2.NumSystem), new PNumber(res.Number, res.NumSystem)));
                return editor.Number = res.Number;
            }
            else if (tag == 29)
            {
                Memory.Clear();
                return editor.Number;
            }
            else if (tag == 30)
            {
                if (Memory.Number.Number == "0")
                    return editor.Number;
                return editor.Number = Memory.Number.Number;
            }
            else if (tag == 31)
            {
                Memory.Number = new PNumber(editor.Number, numSystem);
                return editor.Number;
            }
            else if (tag == 32)
            {
                return editor.Number = Memory.Sub(new PNumber(editor.Number, numSystem)).Number;
            }
            else if (tag == 33)
            {
                return editor.Number = Memory.Add(new PNumber(editor.Number, numSystem)).Number;
            }
            return "";
        }
    }
}
