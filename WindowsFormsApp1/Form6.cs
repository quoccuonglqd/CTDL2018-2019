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
    public partial class Form6 : Form
    {
        public Form6()
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
    }
}
