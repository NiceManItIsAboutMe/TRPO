using Calculator.Calc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            UpdateButtons();
        }

        MyControl control = new MyControl();

        private void DoCommand(int tag)
        {
            if (tag == -1)
                return;
            string str = control.DoCommand(tag);

            if (tag == 21)
            {
                operationTextBox.Text = control.proc.Num1.Number + "+";
            }
            else if (tag == 22)
            {
                operationTextBox.Text = control.proc.Num1.Number + "-";
            }
            else if (tag == 23)
            {
                operationTextBox.Text = control.proc.Num1.Number + "*";
            }
            else if (tag == 24)
            {
                operationTextBox.Text = control.proc.Num1.Number + "/";
            }


            if (control.proc.Operation != EOperation.None)
            {
                if (tag != 28)
                    operationTextBox.Visible = true;
                else if (control.proc.Operation != EOperation.None)
                {
                    operationTextBox.Visible = false;
                    operationTextBox.Text = "0";
                }
            }
            else
            {
                operationTextBox.Visible = false;
                operationTextBox.Text = "0";
            }

            mainTextBox.Text = str;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            try
            {
                Button but = (Button)sender;
                int tag = Convert.ToInt16(but.Tag.ToString());
                DoCommand(tag);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                mainTextBox.Text=control.DoCommand(20);
            }
        }

        private void numSysTrackBar_Scroll(object sender, EventArgs e)
        {
            numSysLabel.Text = "Система счисления: " + numSysTrackBar.Value;
            mainTextBox.Text = control.ChangeSystem(numSysTrackBar.Value);
            if (operationTextBox.Text.Length > 1)
            {
                string temp = operationTextBox.Text.Substring(operationTextBox.Text.Length - 1, 1);
                operationTextBox.Text = control.proc.Num1.Number + temp;
            }
            UpdateButtons();
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm hf = new HistoryForm(control.history);
            hf.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0-1, A-F \t- ввод цифр\n" +
                            "+, -, *, / \t- соответствующие действия\n" +
                            ", или . \t- точка\n" +
                            "Стрелки \t- смена системы счисления", "Справка");
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Некий калькулятор\n\n" +
                            "Выполнен: Константином, Ульянычем и Никитосом", "О программе");
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButtons()
        {
            foreach (Control i in this.Controls)
            {
                if (i is Button)
                {
                    int j = Convert.ToInt16(i.Tag.ToString());
                    if (j < numSysTrackBar.Value)
                    {
                        i.Enabled = true;
                    }
                    if ((j >= numSysTrackBar.Value) && (j <= 15))
                    {
                        i.Enabled = false;
                    }
                }
            }
        }
        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            int i = -1;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'F') i =
           (int)e.KeyChar - 'A' + 10;
            if (e.KeyChar >= 'a' && e.KeyChar <= 'f') i =
           (int)e.KeyChar - 'a' + 10;
            if (e.KeyChar >= '0' && e.KeyChar <= '9') i =
           (int)e.KeyChar - '0';
            if (e.KeyChar == '.') i = 16;
            if ((int)e.KeyChar == 8) i = 18;
            if ((int)e.KeyChar == 13) i = 28;
            if (e.KeyChar == '+') i = 21;
            if (e.KeyChar == '-') i = 22;
            if (e.KeyChar == '*') i = 23;
            if (e.KeyChar == '/') i = 24;
            if ((i < control.numSystem) || (i >= 16)) DoCommand(i);
        }
    }
}
