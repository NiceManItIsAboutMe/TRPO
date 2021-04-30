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

        public bool isEqualLastCommand=false;
        public int numSystem { get; set; } = 10;

        public string ChangeSystem(int numSystem)
        {
            editor.Number.ChangeNumSystem(numSystem);
            this.numSystem = numSystem;
            proc.Num1.ChangeNumSystem(numSystem);
            proc.Num2.ChangeNumSystem(numSystem);
            return editor.Number.Number;

        }
        public string DoCommand(int tag)
        {
           
       
            if (tag <= 22) // это ввод символов и их удаление а также одиночные операции (sqr sqrt rec)
            {
                    isEqualLastCommand = false;
                    return editor.DoEdit(tag).Number;
            }
            else if (tag == 23) // это CE
            {
                    isEqualLastCommand = false;
                    proc.Clear();
                return editor.Clear().Number;
            }
            else if (tag <= 27) // это операции + - / *
            {
                if (proc.Operation != EOperation.None && editor.Number.Number != "0"&&!isEqualLastCommand)
                {
                    DoCommand(28);
                }
                else
                {
                    proc.Num1 = new PNumber(editor.Number);

                }
                isEqualLastCommand = false;
                proc.SwitchOperation(tag);
                return editor.Clear().Number;
            }
            else if (tag == 28) // это равно
            {
                if (editor.Number.Number != "0" && !isEqualLastCommand) // если не равно 0 то это 2 число
                    proc.Num2 = new PNumber(editor.Number);
                else if (!isEqualLastCommand)  
                    proc.Num2 = new PNumber(proc.Num1);
                else // если была нажата кнопка равно и больше ничего то нужно повторить прошлое действие
                    return (editor.Number = new PNumber(proc.DoOperation())).Number;
                isEqualLastCommand = true;
                return (editor.Number = new PNumber(proc.DoOperation())).Number;
                
            }
            else if (tag == 29)
            {
                Memory.Clear();
                return editor.Number.Number;
            }
            else if (tag == 30)
            {
                if (Memory.Number.Number != "0")
                    editor.Number = new PNumber(Memory.Number);
                return editor.Number.Number;
            }
            else if (tag == 31)
            {
                if (editor.Number.Number != "0")
                    Memory.Number=new PNumber(editor.Number);
                return editor.Number.Number;
            }
            else if (tag == 32)
            {
                Memory.Number = editor.Number - Memory.Number;
                return (editor.Number = new PNumber(Memory.Number)).Number;
            }
            else if (tag == 33)
            {
                Memory.Number = editor.Number + Memory.Number;
                return (editor.Number = new PNumber(Memory.Number)).Number;
            }
            return "что-то пошло не так фикси";
        }
    }
}
