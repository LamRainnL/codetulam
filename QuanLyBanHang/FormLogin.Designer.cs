namespace QuanLyBanHang
{
    partial class frmlogin
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
            this.grbdangnhap = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndangky = new System.Windows.Forms.Button();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quayVềTrangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.grbdangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbdangnhap
            // 
            this.grbdangnhap.BackColor = System.Drawing.Color.Transparent;
            this.grbdangnhap.Controls.Add(this.linkLabel1);
            this.grbdangnhap.Controls.Add(this.pictureBox2);
            this.grbdangnhap.Controls.Add(this.pictureBox1);
            this.grbdangnhap.Controls.Add(this.label1);
            this.grbdangnhap.Controls.Add(this.btndangky);
            this.grbdangnhap.Controls.Add(this.btndangnhap);
            this.grbdangnhap.Controls.Add(this.txtmatkhau);
            this.grbdangnhap.Controls.Add(this.txttendangnhap);
            this.grbdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grbdangnhap.ForeColor = System.Drawing.Color.Black;
            this.grbdangnhap.Location = new System.Drawing.Point(496, 33);
            this.grbdangnhap.Name = "grbdangnhap";
            this.grbdangnhap.Size = new System.Drawing.Size(333, 351);
            this.grbdangnhap.TabIndex = 0;
            this.grbdangnhap.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyBanHang.Properties.Resources.Security_Password_2_icon;
            this.pictureBox2.Location = new System.Drawing.Point(15, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.Users_Name_icon;
            this.pictureBox1.Location = new System.Drawing.Point(15, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "----------------------------------------------";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btndangky
            // 
            this.btndangky.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btndangky.Location = new System.Drawing.Point(86, 274);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(168, 49);
            this.btndangky.TabIndex = 3;
            this.btndangky.Text = "Tạo tài khoản mới";
            this.btndangky.UseVisualStyleBackColor = false;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.btndangnhap.Location = new System.Drawing.Point(109, 169);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(121, 42);
            this.btndangnhap.TabIndex = 2;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BackColor = System.Drawing.Color.White;
            this.txtmatkhau.Location = new System.Drawing.Point(75, 107);
            this.txtmatkhau.Multiline = true;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(208, 34);
            this.txtmatkhau.TabIndex = 1;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.BackColor = System.Drawing.Color.White;
            this.txttendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendangnhap.Location = new System.Drawing.Point(75, 34);
            this.txttendangnhap.Multiline = true;
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(208, 35);
            this.txttendangnhap.TabIndex = 0;
            this.txttendangnhap.Text = "Nhập mã nhân viên";
            this.txttendangnhap.Enter += new System.EventHandler(this.txttendangnhap_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayVềTrangChủToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quayVềTrangChủToolStripMenuItem
            // 
            this.quayVềTrangChủToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.quayVềTrangChủToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.Home_icon;
            this.quayVềTrangChủToolStripMenuItem.Name = "quayVềTrangChủToolStripMenuItem";
            this.quayVềTrangChủToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.quayVềTrangChủToolStripMenuItem.Text = "Quay về trang chủ";
            this.quayVềTrangChủToolStripMenuItem.Click += new System.EventHandler(this.quayVềTrangChủToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(174, 225);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 18);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.grbdangnhap);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmlogin";
            this.Text = "Đăng nhập";
            this.grbdangnhap.ResumeLayout(false);
            this.grbdangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayVềTrangChủToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grbdangnhap;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}