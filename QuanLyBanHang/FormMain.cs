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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        
        //Quản lý SP
        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin f = new frmlogin();
            f.Show();
            this.Hide();
        }
        //Đăng nhập
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin f = new frmlogin();
            f.Show();
            this.Hide();
        }
        //Trợ giúp
        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtrogiup f = new frmtrogiup();
            f.Show();
        }
        //Quan lý HD
        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin f = new frmlogin();
            f.Show();
            this.Hide();
        }
        //Thoát
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
