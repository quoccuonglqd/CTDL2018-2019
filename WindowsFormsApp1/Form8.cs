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
    public partial class Form8 : Form
    {
        public Form8(string Mystring,string src)
        {
            InitializeComponent();

            char[] str = src.ToCharArray();
            int len = src.Length;
            string str1 = "", str2 = "";
            int id = 0;
            for (; str[id] != ' '; id++) str1 = str1 + str[id].ToString();
            for (id = id + 1; str[id] != ' '; id++) str2 = str2 + str[id].ToString();

            label2.Text = Mystring;
            label4.Text = str1;
            label6.Text = str2;


            while (id+1<len)
            {
                string str3 = "";
                id++;
                while (str[id] != ' ')
                {
                    str3 = str3 + str[id].ToString();
                    id++;
                }
                ListViewItem liv = new ListViewItem(str3);


                for (int i=1;i<=2;i++)
                {
                    string str4 = "";
                    id++;
                    while (str[id] != ' ')
                    {
                        str4 = str4 + str[id].ToString();
                        id++;
                    }
                    liv.SubItems.Add(str4);
                }

                string str5 = "";
                id++;
                while (str[id] != ' ')
                {
                    str5 = str5 + str[id].ToString();
                    id++;
                }
                string str6 = "";
                id++;
                while (str[id] != ' ')
                {
                    str6 = str6 + str[id].ToString();
                    id++;
                }
                str5 = str5 + " " + str6;
                liv.SubItems.Add(str5);

                str6 = "";
                id++;
                while (str[id] != ' ')
                {
                    str6 = str6 + str[id].ToString();
                    id++;
                }
                liv.SubItems.Add(str6);

                listView1.Items.Add(liv);
              
            }
        }
    }
}
