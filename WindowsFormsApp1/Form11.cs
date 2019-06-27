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
    public partial class Form11 : Form
    {
        public Form11(string a,string src)
        {
            InitializeComponent();
            label2.Text = a;
            char[] str = src.ToCharArray();

            int id = -1;
            string s = "";
            while (id+1<src.Length)
            {
                id++;
                s = "";
                while (str[id]!=' ')
                {
                    s = s + str[id].ToString();
                    id++;
                }
                ListViewItem liv = new ListViewItem(s);
                listView1.Items.Add(liv);
            }
        }
    }
}
