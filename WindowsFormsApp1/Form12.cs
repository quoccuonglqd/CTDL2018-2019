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
    public partial class Form12 : Form
    {
        public Form12(string src)
        {
            InitializeComponent();
            char[] str = src.ToCharArray();
            int id = -1;
            int cnt = 0;
            string s1 = "";
            string s2 = "";

            while (id+1<src.Length)
            {
                s1 = "";
                s2 = "";
                id++;
                ListViewItem liv = new ListViewItem((++cnt).ToString());
                while (str[id] != ' ') { s1 = s1 + str[id].ToString(); id++; }
                liv.SubItems.Add(s1);
                id++;
                while (str[id] != ' ') { s2 = s2 + str[id].ToString(); id++; }
                liv.SubItems.Add(s2);

                listView1.Items.Add(liv);
            }
        }
    }
}
