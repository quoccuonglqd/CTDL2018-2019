using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Create();

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr getFlightlist(IntPtr ptr); 

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr getAirplanelist(IntPtr ptr);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr getPassengerlist(IntPtr ptr);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void  addairplane(IntPtr ptr, string a, string b, int c);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void deleteairplane(IntPtr ptr, string a);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void changeairplane(IntPtr ptr, string a, string b, int c);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void addflight(IntPtr ptr, string a, string b, string c, string e);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Changeflightdepart(IntPtr ptr, string a, string src);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Denyflight(IntPtr ptr, string a);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void bookticket(IntPtr ptr, string a, int id, string cmnd, string name, string surname, string sex);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void passengerinfo_of_flight(IntPtr ptr, string Id); 

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void flightinfo(IntPtr ptr, string a, string b);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void availticket_info(IntPtr ptr, string x);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Flightinfo(IntPtr ptr);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void getdatafromfile(IntPtr ptr, string Airplane, string Flight, string Ticket, string Passenger);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void saveintofile(IntPtr ptr, string Airplane, string Flight, string Ticket, string Passenger);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool check_ticket_booked(IntPtr ptr, string a, int id);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool check_CMND_booked(IntPtr ptr, string a, string cmnd);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool check_plane_exist(IntPtr ptr, string a);

        [DllImport("backend.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool check_flight_exist(IntPtr ptr, string a);

        IntPtr obj = Create();
        string Airplane = "Airplanedata.txt";
        string Flight =   "Flightdata.txt";
        string Ticket =   "Flightticketdata.txt";
        string Passenger ="Passengerdata.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void lưuDữLiệuHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveintofile(obj, Airplane, Flight, Ticket, Passenger);
            MessageBox.Show("Lưu dữ liệu thành công", "Announcement", MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void tảiLênDữLiệuĐãLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getdatafromfile(obj, Airplane, Flight, Ticket, Passenger);
            MessageBox.Show("Tải lên dữ liệu thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void đặtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            while (f.ShowDialog() == DialogResult.OK)
            {
                if (f.getTB1() == "" || f.getTB2() == "" || f.getTB3() == "" || f.getTB5() == "" || f.getTB6()=="" || (f.getCB2() == false && f.getCB1() == false))
                {
                    MessageBox.Show("Chưa điền đủ thông tin", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                string a = f.getTB5();
                int id = Convert.ToInt32(f.getTB6());
                string cmnd = f.getTB1();
                string name = f.getTB3();
                string surname = f.getTB2();
                string sex;
                if (f.getCB2() == true) sex = "male";
                else sex = "female";
                if (check_ticket_booked(obj,a,id)==true)
                {
                    MessageBox.Show("Vé đã được đặt", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                if (check_CMND_booked(obj, a, cmnd) == true)
                {
                    MessageBox.Show("Khách hàng đã đặt vé trên chuyến bay này", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                bookticket(obj, a, id, cmnd, name, surname, sex);
                MessageBox.Show("Đặt vé thành công", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.Close();
                break;
            }
        }

        private void addFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            while (f.ShowDialog()==DialogResult.OK)
            {
                if (f.getTB1() == "" || f.getTB2() == "" || f.getTB3() == "" || f.getTB4() == "" )
                {
                    MessageBox.Show("Chưa điền đủ thông tin", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                string a = f.getTB1();
                string b = f.getTB2();
                string c = f.getTB3();
                string d = f.getTB4();
                if (check_flight_exist(obj,a)==true)
                {
                    MessageBox.Show("Mã chuyến bay này đã tồn tại", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                if (check_plane_exist(obj,d)==false)
                {
                    MessageBox.Show("Mã máy bay này không tồn tại", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                addflight(obj, a, b, c, d);
                
                MessageBox.Show("Thêm chuyến bay thành công", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.Close();
                break;
            }

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            while (f.ShowDialog()==DialogResult.OK)
            {
                if (f.getTB1()=="")
                {
                    MessageBox.Show("Chưa điền đủ thông tin", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                string a = f.getTB1();
                if (check_flight_exist(obj,a)==false)
                {
                    MessageBox.Show("Mã chuyến bay này không tồn tại", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    f.Close();
                    break;
                }
                Denyflight(obj, a);
                MessageBox.Show("Hủy chuyến bay thành công", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.Close();
                break;
            }
        }

        private void chỉnhSửaThờiGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            while (f.ShowDialog()==DialogResult.OK)
            {
                if (f.getTB1() == "" || f.getTB2()=="")
                {
                    MessageBox.Show("Chưa điền đủ thông tin", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                string a = f.getTB1();
                string b = f.getTB2();
                if (check_flight_exist(obj,a)==false)
                {
                    MessageBox.Show("Mã chuyến bay này không tồn tại", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    f.Close();
                    break;
                }
                Changeflightdepart(obj, a, b);
                MessageBox.Show("Đặt lại ngày khởi hành thành công", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.Close();
                break;
            }
        }

        private void xóaMáyBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.setLabel1("Mã máy bay cần xóa");
            while (f.ShowDialog() == DialogResult.OK)
            {
                if (f.getTB1() == "")
                {
                    MessageBox.Show("Chưa điền đủ thông tin", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                string a = f.getTB1();
                if (check_plane_exist(obj, a) == false)
                {
                    MessageBox.Show("Mã máy bay này không tồn tại", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    f.Close();
                    break;
                }
                deleteairplane(obj, a);
                MessageBox.Show("Xóa máy bay thành công", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.Close();
                break;
            }
        }

        private void thêmMáyBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            while (f.ShowDialog() == DialogResult.OK)
            {
                if (f.getTB1() == "" || f.getTB2() == "" || f.getTB3() == "" )
                {
                    MessageBox.Show("Chưa điền đủ thông tin", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                if (Convert.ToInt32(f.getTB3())<20)
                {
                    MessageBox.Show("Số chỗ phải >= 20", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                string a = f.getTB1();
                string b = f.getTB2();
                int c = Convert.ToInt32(f.getTB3());
                if (check_flight_exist(obj, a) == true)
                {
                    MessageBox.Show("Mã máy bay này đã tồn tại", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                addairplane(obj, a, b, c);
                MessageBox.Show("Thêm máy bay thành công", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.Close();
                break;
            }
        }

        private void hiệuChỉnhThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            while (f.ShowDialog() == DialogResult.OK)
            {
                if (f.getTB1() == "" || f.getTB2() == "" || f.getTB3() == "")
                {
                    MessageBox.Show("Chưa điền đủ thông tin", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                if (Convert.ToInt32(f.getTB3()) < 20)
                {
                    MessageBox.Show("Số chỗ phải >= 20", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                string a = f.getTB1();
                string b = f.getTB2();
                int c = Convert.ToInt32(f.getTB3());
                if (check_plane_exist(obj, a) == false)
                {
                    MessageBox.Show("Mã máy bay này không tồn tại", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    f.Close();
                    break;
                }
                changeairplane(obj, a, b, c);
                MessageBox.Show("Hiệu chỉnh thành công", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.Close();
                break;
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool tf = true;
            Form4 f = new Form4();
            f.setLabel1("Mã chuyến bay ");
            f.setButton("Thống kê");
            string Mystring="";
            while (f.ShowDialog()==DialogResult.OK)
            {
                if (f.getTB1()=="")
                {
                    MessageBox.Show("Chưa điền đủ thông tin", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                Mystring = f.getTB1();
                if (check_flight_exist(obj,Mystring)==false)
                {
                    MessageBox.Show("Mã chuyến bay không tồn tại", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tf = false;
                    f.Close();
                    break;
                }
                f.Close();
                break;
            }
            if (tf == false) return;
            string str = "";
            passengerinfo_of_flight(obj,Mystring);
            using (StreamReader sr = File.OpenText("output1.txt"))
            {
                str = sr.ReadLine();
            }
            Form8 ff = new Form8(Mystring,str);
            ff.Show();
        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            string a = "";
            string b = "";
            while (f.ShowDialog() == DialogResult.OK)
            {
                if (f.getTB1() == "" || f.getTB2() == "")
                {
                    MessageBox.Show("Chưa điền đủ thông tin", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                a = f.getTB1();
                b = f.getTB2();
                f.Close();
                break;
            }

            flightinfo(obj, a, b);
            string str = "";
            using (StreamReader sr = File.OpenText("output2.txt"))
            {
                str = sr.ReadLine();
            }
            if (str=="not")
            {
                MessageBox.Show("Không có chuyến bay phù hợp", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Form10 ff = new Form10(a, b, str);
            ff.Show();
        }

        private void thốngKêDanhSáchVéTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool tf = true;
            Form4 f = new Form4();
            f.setLabel1("Mã chuyến bay ");
            f.setButton("Thống kê");
            string Mystring = "";
            while (f.ShowDialog() == DialogResult.OK)
            {
                if (f.getTB1() == "")
                {
                    MessageBox.Show("Chưa điền đủ thông tin", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                Mystring = f.getTB1();
                if (check_flight_exist(obj, Mystring) == false)
                {
                    MessageBox.Show("Mã chuyến bay không tồn tại", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tf = false;
                    f.Close();
                    break;
                }
                f.Close();
                break;
            }
            if (tf == false) return;
            string str = "";
            availticket_info(obj, Mystring);
            using (StreamReader sr = File.OpenText("output3.txt"))
            {
                str = sr.ReadLine();
            }
            if (str == "not")
            {
                MessageBox.Show("Không còn vé trống", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Form11 ff = new Form11(Mystring, str);
            ff.Show();
        }

        private void thốngKêSốLượtThựcHiệnChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flightinfo(obj);
            string str = "";
            using (StreamReader sr = File.OpenText("output4.txt"))
            {
                str = sr.ReadLine();
            }
            Form12 f = new Form12(str);
            f.Show();
        }
    }
}