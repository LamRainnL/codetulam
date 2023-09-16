namespace QuanLyBanHang
{
    partial class frmhoadon
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
            this.grbthongtin = new System.Windows.Forms.GroupBox();
            this.cbbmasp = new System.Windows.Forms.ComboBox();
            this.cbbmanv = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbthaotac = new System.Windows.Forms.GroupBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.datathongtin = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbthongtin.SuspendLayout();
            this.grbthaotac.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datathongtin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbthongtin
            // 
            this.grbthongtin.Controls.Add(this.cbbmasp);
            this.grbthongtin.Controls.Add(this.cbbmanv);
            this.grbthongtin.Controls.Add(this.dtp);
            this.grbthongtin.Controls.Add(this.txtsohd);
            this.grbthongtin.Controls.Add(this.label4);
            this.grbthongtin.Controls.Add(this.label3);
            this.grbthongtin.Controls.Add(this.label2);
            this.grbthongtin.Controls.Add(this.label1);
            this.grbthongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grbthongtin.Location = new System.Drawing.Point(211, 31);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Size = new System.Drawing.Size(466, 275);
            this.grbthongtin.TabIndex = 1;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Thông tin hóa đơn";
            // 
            // cbbmasp
            // 
            this.cbbmasp.FormattingEnabled = true;
            this.cbbmasp.Location = new System.Drawing.Point(190, 206);
            this.cbbmasp.Name = "cbbmasp";
            this.cbbmasp.Size = new System.Drawing.Size(228, 26);
            this.cbbmasp.TabIndex = 13;
            // 
            // cbbmanv
            // 
            this.cbbmanv.FormattingEnabled = true;
            this.cbbmanv.Location = new System.Drawing.Point(190, 153);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.Size = new System.Drawing.Size(228, 26);
            this.cbbmanv.TabIndex = 12;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(190, 102);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(228, 24);
            this.dtp.TabIndex = 11;
            // 
            // txtsohd
            // 
            this.txtsohd.Location = new System.Drawing.Point(190, 54);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(228, 24);
            this.txtsohd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã sản phẩm xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hóa đơn";
            // 
            // grbthaotac
            // 
            this.grbthaotac.Controls.Add(this.btnlammoi);
            this.grbthaotac.Controls.Add(this.btnsua);
            this.grbthaotac.Controls.Add(this.btnthem);
            this.grbthaotac.Location = new System.Drawing.Point(135, 302);
            this.grbthaotac.Name = "grbthaotac";
            this.grbthaotac.Size = new System.Drawing.Size(629, 102);
            this.grbthaotac.TabIndex = 2;
            this.grbthaotac.TabStop = false;
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlammoi.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnlammoi.Image = global::QuanLyBanHang.Properties.Resources.refresh_icon1;
            this.btnlammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlammoi.Location = new System.Drawing.Point(449, 21);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(127, 56);
            this.btnlammoi.TabIndex = 4;
            this.btnlammoi.Text = "Làm \r\nmới";
            this.btnlammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnsua.Image = global::QuanLyBanHang.Properties.Resources.build_outline_icon2;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(242, 21);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(127, 56);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnthem.Image = global::QuanLyBanHang.Properties.Resources.add_icon1;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(32, 21);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(127, 56);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Controls.Add(this.txtsearch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(51, 410);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnsearch
            // 
            this.btnsearch.BackgroundImage = global::QuanLyBanHang.Properties.Resources.search_icon;
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsearch.Location = new System.Drawing.Point(563, 32);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 33);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(84, 36);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(454, 24);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.Text = "Tra cứu hóa đơn theo tên sản phẩm";
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
            // 
            // datathongtin
            // 
            this.datathongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datathongtin.Location = new System.Drawing.Point(51, 516);
            this.datathongtin.Name = "datathongtin";
            this.datathongtin.RowHeadersWidth = 51;
            this.datathongtin.RowTemplate.Height = 24;
            this.datathongtin.Size = new System.Drawing.Size(763, 162);
            this.datathongtin.TabIndex = 3;
            this.datathongtin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datathongtin_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayLạiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayLạiToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.chevron_back_circle_outline_icon;
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.quayLạiToolStripMenuItem.Text = "Quay lại";
            this.quayLạiToolStripMenuItem.Click += new System.EventHandler(this.quayLạiToolStripMenuItem_Click);
            // 
            // frmhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 676);
            this.Controls.Add(this.datathongtin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbthaotac);
            this.Controls.Add(this.grbthongtin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmhoadon";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.frmhoadon_Load);
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            this.grbthaotac.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datathongtin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbthongtin;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbthaotac;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datathongtin;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.ComboBox cbbmasp;
        private System.Windows.Forms.ComboBox cbbmanv;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
    }
}