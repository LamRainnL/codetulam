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
    public partial class frmlogin : Form
    {
        
        public frmlogin()
        {
            InitializeComponent();
        }
        BUS_NhanVien busnv = new BUS_NhanVien();
        
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if( txttendangnhap.Text != "" && txtmatkhau.Text!="")
            {
                //tài khoản admin
              if(txttendangnhap.Text.Equals("lam") && txtmatkhau.Text.Equals("208"))
                {
                    frmnhanvien f = new frmnhanvien();
                    f.Show();
                    this.Hide();
                }
              else if (busnv.loginTendn(txttendangnhap.Text))
                {
                    if (busnv.loginMatkhau(txtmatkhau.Text))
                    {
                        GUI_SanPham f = new GUI_SanPham();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng nhập không chính xác!");
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác!");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                txttendangnhap.Focus();
            }
            
            
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            FormDangKy form= new FormDangKy();
            form.Show();   
        }

        private void quayVềTrangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            f.Show();
            this.Close();
        }

      
        private void txttendangnhap_Enter(object sender, EventArgs e)
        {
            txttendangnhap.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmchangepass f = new frmchangepass();
            f.Show();
            this.Hide();
        }
    }
}
