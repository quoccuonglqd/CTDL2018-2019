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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string getTB1()
        {
            return TB1.Text;
        }

        public void setLabel1(string src)
        {
            label1.Text = src;
        }

        public void setButton(string src)
        {
            button1.Text = src;
        }  
    }
}
