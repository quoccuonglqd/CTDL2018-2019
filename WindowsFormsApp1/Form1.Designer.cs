namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.planemenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmMáyBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaMáyBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiệuChỉnhThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customermenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flightmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaThờiGianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuDữLiệuHiệnTạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tảiLênDữLiệuĐãLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDanhSáchVéTrốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêSốLượtThựcHiệnChuyếnBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.planemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flightmenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(486, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 471);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.ContextMenuStrip = this.planemenu;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 319);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 146);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // planemenu
            // 
            this.planemenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMáyBayToolStripMenuItem,
            this.xóaMáyBayToolStripMenuItem,
            this.hiệuChỉnhThôngTinToolStripMenuItem});
            this.planemenu.Name = "planemenu";
            this.planemenu.Size = new System.Drawing.Size(185, 70);
            // 
            // thêmMáyBayToolStripMenuItem
            // 
            this.thêmMáyBayToolStripMenuItem.Name = "thêmMáyBayToolStripMenuItem";
            this.thêmMáyBayToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.thêmMáyBayToolStripMenuItem.Text = "Thêm máy bay";
            this.thêmMáyBayToolStripMenuItem.Click += new System.EventHandler(this.thêmMáyBayToolStripMenuItem_Click);
            // 
            // xóaMáyBayToolStripMenuItem
            // 
            this.xóaMáyBayToolStripMenuItem.Name = "xóaMáyBayToolStripMenuItem";
            this.xóaMáyBayToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.xóaMáyBayToolStripMenuItem.Text = "Xóa máy bay";
            this.xóaMáyBayToolStripMenuItem.Click += new System.EventHandler(this.xóaMáyBayToolStripMenuItem_Click);
            // 
            // hiệuChỉnhThôngTinToolStripMenuItem
            // 
            this.hiệuChỉnhThôngTinToolStripMenuItem.Name = "hiệuChỉnhThôngTinToolStripMenuItem";
            this.hiệuChỉnhThôngTinToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.hiệuChỉnhThôngTinToolStripMenuItem.Text = "Hiệu chỉnh thông tin";
            this.hiệuChỉnhThôngTinToolStripMenuItem.Click += new System.EventHandler(this.hiệuChỉnhThôngTinToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ContextMenuStrip = this.customermenu;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // customermenu
            // 
            this.customermenu.Name = "customermenu";
            this.customermenu.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.flightmenu;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flightmenu
            // 
            this.flightmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFlightToolStripMenuItem,
            this.dToolStripMenuItem,
            this.chỉnhSửaThờiGianToolStripMenuItem});
            this.flightmenu.Name = "flightmenu";
            this.flightmenu.Size = new System.Drawing.Size(181, 70);
            // 
            // addFlightToolStripMenuItem
            // 
            this.addFlightToolStripMenuItem.Name = "addFlightToolStripMenuItem";
            this.addFlightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addFlightToolStripMenuItem.Text = "Thêm chuyến bay";
            this.addFlightToolStripMenuItem.Click += new System.EventHandler(this.addFlightToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dToolStripMenuItem.Text = "Hủy chuyến";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // chỉnhSửaThờiGianToolStripMenuItem
            // 
            this.chỉnhSửaThờiGianToolStripMenuItem.Name = "chỉnhSửaThờiGianToolStripMenuItem";
            this.chỉnhSửaThờiGianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chỉnhSửaThờiGianToolStripMenuItem.Text = "Chỉnh sửa thời gian ";
            this.chỉnhSửaThờiGianToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaThờiGianToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.requestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lưuDữLiệuHiệnTạiToolStripMenuItem,
            this.tảiLênDữLiệuĐãLưuToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lưuDữLiệuHiệnTạiToolStripMenuItem
            // 
            this.lưuDữLiệuHiệnTạiToolStripMenuItem.Name = "lưuDữLiệuHiệnTạiToolStripMenuItem";
            this.lưuDữLiệuHiệnTạiToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.lưuDữLiệuHiệnTạiToolStripMenuItem.Text = "Lưu dữ liệu hiện tại";
            this.lưuDữLiệuHiệnTạiToolStripMenuItem.Click += new System.EventHandler(this.lưuDữLiệuHiệnTạiToolStripMenuItem_Click);
            // 
            // tảiLênDữLiệuĐãLưuToolStripMenuItem
            // 
            this.tảiLênDữLiệuĐãLưuToolStripMenuItem.Name = "tảiLênDữLiệuĐãLưuToolStripMenuItem";
            this.tảiLênDữLiệuĐãLưuToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tảiLênDữLiệuĐãLưuToolStripMenuItem.Text = "Tải lên dữ liệu đã lưu";
            this.tảiLênDữLiệuĐãLưuToolStripMenuItem.Click += new System.EventHandler(this.tảiLênDữLiệuĐãLưuToolStripMenuItem_Click);
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtVéToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.thốngKêToolStripMenuItem1,
            this.thốngKêDanhSáchVéTrốngToolStripMenuItem,
            this.thốngKêSốLượtThựcHiệnChuyếnBayToolStripMenuItem});
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.requestToolStripMenuItem.Text = "Request";
            // 
            // đặtVéToolStripMenuItem
            // 
            this.đặtVéToolStripMenuItem.Name = "đặtVéToolStripMenuItem";
            this.đặtVéToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.đặtVéToolStripMenuItem.Text = "Đặt vé";
            this.đặtVéToolStripMenuItem.Click += new System.EventHandler(this.đặtVéToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.thốngKêToolStripMenuItem.Text = "Thống kê hành khách theo chuyến bay";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem1
            // 
            this.thốngKêToolStripMenuItem1.Name = "thốngKêToolStripMenuItem1";
            this.thốngKêToolStripMenuItem1.Size = new System.Drawing.Size(280, 22);
            this.thốngKêToolStripMenuItem1.Text = "Thống kê chuyến bay";
            this.thốngKêToolStripMenuItem1.Click += new System.EventHandler(this.thốngKêToolStripMenuItem1_Click);
            // 
            // thốngKêDanhSáchVéTrốngToolStripMenuItem
            // 
            this.thốngKêDanhSáchVéTrốngToolStripMenuItem.Name = "thốngKêDanhSáchVéTrốngToolStripMenuItem";
            this.thốngKêDanhSáchVéTrốngToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.thốngKêDanhSáchVéTrốngToolStripMenuItem.Text = "Thống kê danh sách vé trống";
            this.thốngKêDanhSáchVéTrốngToolStripMenuItem.Click += new System.EventHandler(this.thốngKêDanhSáchVéTrốngToolStripMenuItem_Click);
            // 
            // thốngKêSốLượtThựcHiệnChuyếnBayToolStripMenuItem
            // 
            this.thốngKêSốLượtThựcHiệnChuyếnBayToolStripMenuItem.Name = "thốngKêSốLượtThựcHiệnChuyếnBayToolStripMenuItem";
            this.thốngKêSốLượtThựcHiệnChuyếnBayToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.thốngKêSốLượtThựcHiệnChuyếnBayToolStripMenuItem.Text = "Thống kê số lượt thực hiện chuyến bay";
            this.thốngKêSốLượtThựcHiệnChuyếnBayToolStripMenuItem.Click += new System.EventHandler(this.thốngKêSốLượtThựcHiệnChuyếnBayToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 111);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(486, 334);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 27);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(486, 334);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 27);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(486, 334);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(656, 471);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirlineManager";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.planemenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flightmenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip flightmenu;
        private System.Windows.Forms.ContextMenuStrip customermenu;
        private System.Windows.Forms.ContextMenuStrip planemenu;
        private System.Windows.Forms.ToolStripMenuItem thêmMáyBayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaMáyBayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiệuChỉnhThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaThờiGianToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuDữLiệuHiệnTạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tảiLênDữLiệuĐãLưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDanhSáchVéTrốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSốLượtThựcHiệnChuyếnBayToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

