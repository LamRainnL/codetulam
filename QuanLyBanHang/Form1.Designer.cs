namespace QuanLyBanHang
{
    partial class GUI_SanPham
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
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtnoisx = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbthaotac = new System.Windows.Forms.GroupBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.datathongtin = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.grbthongtin.SuspendLayout();
            this.grbthaotac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datathongtin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbthongtin
            // 
            this.grbthongtin.Controls.Add(this.txtsl);
            this.grbthongtin.Controls.Add(this.txtgia);
            this.grbthongtin.Controls.Add(this.txtnoisx);
            this.grbthongtin.Controls.Add(this.txttensp);
            this.grbthongtin.Controls.Add(this.txtmasp);
            this.grbthongtin.Controls.Add(this.label6);
            this.grbthongtin.Controls.Add(this.label4);
            this.grbthongtin.Controls.Add(this.label3);
            this.grbthongtin.Controls.Add(this.label2);
            this.grbthongtin.Controls.Add(this.label1);
            this.grbthongtin.Location = new System.Drawing.Point(12, 12);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Size = new System.Drawing.Size(414, 275);
            this.grbthongtin.TabIndex = 0;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Thông tin sản phẩm";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(219, 240);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(148, 22);
            this.txtsl.TabIndex = 11;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(219, 181);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(148, 22);
            this.txtgia.TabIndex = 10;
            // 
            // txtnoisx
            // 
            this.txtnoisx.Location = new System.Drawing.Point(219, 134);
            this.txtnoisx.Name = "txtnoisx";
            this.txtnoisx.Size = new System.Drawing.Size(148, 22);
            this.txtnoisx.TabIndex = 9;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(219, 74);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(148, 22);
            this.txttensp.TabIndex = 7;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(219, 32);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(148, 22);
            this.txtmasp.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nơi sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // grbthaotac
            // 
            this.grbthaotac.Controls.Add(this.btnsua);
            this.grbthaotac.Controls.Add(this.btnxoa);
            this.grbthaotac.Controls.Add(this.btnthem);
            this.grbthaotac.Location = new System.Drawing.Point(575, 12);
            this.grbthaotac.Name = "grbthaotac";
            this.grbthaotac.Size = new System.Drawing.Size(200, 275);
            this.grbthaotac.TabIndex = 1;
            this.grbthaotac.TabStop = false;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(67, 211);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(67, 134);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(67, 53);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // datathongtin
            // 
            this.datathongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datathongtin.Location = new System.Drawing.Point(12, 502);
            this.datathongtin.Name = "datathongtin";
            this.datathongtin.RowHeadersWidth = 51;
            this.datathongtin.RowTemplate.Height = 24;
            this.datathongtin.Size = new System.Drawing.Size(763, 209);
            this.datathongtin.TabIndex = 2;
            this.datathongtin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datathongtin_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sản phẩm";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(69, 51);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(454, 22);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.Text = " Nhập tên sản phẩm cần tìm";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(594, 49);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Tìm ";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // GUI_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datathongtin);
            this.Controls.Add(this.grbthaotac);
            this.Controls.Add(this.grbthongtin);
            this.Name = "GUI_SanPham";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.GUI_SanPham_Load_1);
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            this.grbthaotac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datathongtin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbthongtin;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtnoisx;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbthaotac;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView datathongtin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
    }
}

