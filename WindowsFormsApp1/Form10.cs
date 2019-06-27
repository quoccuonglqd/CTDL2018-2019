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
    public partial class Form10 : Form
    {
        public Form10(string a,string b,string src)
        {
            InitializeComponent();
            label2.Text = a;
            label4.Text = b;
            int len = src.Length;
            char[] str = src.ToCharArray();

            int id = -1;
            string s1 = "";
            string s2 = "";
            while (id+1<len)
            {
                s1 = "";
                s2 = "";
                id++;
                while (str[id] != ' ') { s1 = s1 + str[id].ToString(); id++; }
                ListViewItem liv = new ListViewItem(s1);
                id++;
                while (str[id] != ' ') { s2 = s2 + str[id].ToString(); id++; }
                liv.SubItems.Add(s2);
                listView1.Items.Add(liv);
            }
        }
    }
}
