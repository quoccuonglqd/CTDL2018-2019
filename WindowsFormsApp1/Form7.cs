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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        
        public string getTB1()
        {
            return textBox1.Text;
        }

        public string getTB2()
        {
            return textBox2.Text;
        }

        public string getTB3()
        {
            return textBox3.Text;
        }
    }
}
