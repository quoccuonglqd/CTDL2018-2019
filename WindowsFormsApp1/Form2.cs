using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string getTB1()
        {
            return TB1.Text;
        }

        public string getTB2()
        {
            return TB2.Text;
        }

        public string getTB3()
        {
            return TB3.Text;
        }
       
        public bool getCB2()
        {
            return checkBox2.CheckState == CheckState.Checked;
        }

        public bool getCB1()
        {
            return checkBox1.CheckState == CheckState.Checked;
        }

        public string getTB5()
        {
            return TB5.Text;
        }

        public string getTB6()
        {
            return TB6.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Unchecked)
                checkBox1.CheckState = CheckState.Checked;
            else checkBox1.CheckState = CheckState.Unchecked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Unchecked)
                checkBox2.CheckState = CheckState.Checked;
            else checkBox2.CheckState = CheckState.Unchecked;
        }
    }
}
