using BUS_BanHang;
using DTO_BanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmchangepass : Form
    {
        BUS_NhanVien busnv= new BUS_NhanVien();
        public frmchangepass()
        {
            InitializeComponent();
        }

        private void frmchangepass_Load(object sender, EventArgs e)
        {
            txtmanv.Focus();
        }

       
        //Quay lại form Đăng nhập
        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin f = new frmlogin();
            f.Show();
            this.Hide();

        }
        //Đổi mật khẩu
        private void btndoimk_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text != "" && txtmatkhau.Text != "")
            {
                if (txtmatkhau.Text.Equals(txtnhaplai.Text))
                {
                    DTO_NhanVien nv = new DTO_NhanVien(txtmanv.Text, txtmatkhau.Text);
                    if (busnv.checkMaNV(nv) == false)
                    {
                        if (busnv.doiMK(nv))
                        {
                            MessageBox.Show("Mật khẩu đã được cập nhật");
                            frmlogin f = new frmlogin();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Đổi không thành công!");
                            txtmanv.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại!");
                        txtmanv.Clear();
                        txtmanv.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Mật khẩu không trùng khớp!");
                }
            }
            else
            {
                MessageBox.Show("Mời nhập đủ thông tin");
            }

        }
    }
}
