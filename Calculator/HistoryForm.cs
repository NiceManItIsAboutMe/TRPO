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
    partial class HistoryForm : Form
    {
        History history;
        public HistoryForm(History history)
        {
            InitializeComponent();
            this.history = history;
            label2.Text = history.ViewText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            history.Clear();
            label2.Text = history.ViewText();
        }

        private void numSysTrackBar_Scroll(object sender, EventArgs e)
        {
            numSysLabel.Text = "Система счисления: " + numSysTrackBar.Value;
            label2.Text = history.ChangeNumSystem(numSysTrackBar.Value);
        }
    }
}
