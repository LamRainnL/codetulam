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
    public partial class FormDangKy : Form
    {
        BUS_NhanVien busnv = new BUS_NhanVien();
        public FormDangKy()
        {
            InitializeComponent();
        }

        //Sự kiện nút đăng ký
        private void btndangky_Click(object sender, EventArgs e)
        {
            if(txtmanv.Text!="" && txthoten.Text!="" && txtmatkhau.Text != "")
            {
                DTO_NhanVien nv = new DTO_NhanVien(txtmanv.Text,txtmatkhau.Text,txthoten.Text);
                if (busnv.checkMaNV(nv))
                {
                    if(busnv.themNV(nv))
                    {
                        MessageBox.Show("Đăng ký thành công");
                        frmlogin f = new frmlogin();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký không thành công!");
                        txtmanv.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!");
                    txtmanv.Clear();
                    txtmanv.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mời nhập đủ thông tin");
            }
          
            
        }
    }
}
