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
using System.Xml.Linq;

namespace QuanLyBanHang
{
    public partial class GUI_SanPham : Form
    {
        BUS_SanPham bussp= new BUS_SanPham();

        public GUI_SanPham()
        {
            InitializeComponent();
        }
        private void loadSP()
        {
            datathongtin.DataSource = bussp.getSanPham();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmasp.Text != "" && txttensp.Text != "" && txtnoisx.Text != "" && txtgia.Text != "" && txtsl.Text != "")
            {
                //tạo DTO
                DTO_SanPham sp = new DTO_SanPham(txtmasp.Text, txttensp.Text, txtnoisx.Text, float.Parse(txtgia.Text), int.Parse(txtsl.Text));
                //check masp
                if (bussp.checkMaSp(sp))
                {
                    //Them
                    if (bussp.themSanPham(sp))
                    {
                        MessageBox.Show("Thêm thành công");
                        datathongtin.DataSource = bussp.getSanPham();//làm mới datagridview
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng mã sản phẩm!");
                    txtmasp.Clear();
                    txtmasp.Focus();
                }
            }
            else
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin!");
            }
            
        }
        private void GUI_SanPham_Load_1(object sender, EventArgs e)
        {
            loadSP();
        }
        //Đưa dữ liệu từ dataGidview lên các constrol
        private void datathongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datathongtin.CurrentCell.RowIndex;//Trả về chỉ số dòng đang chọn
            txtmasp.Text = datathongtin.Rows[i].Cells[0].Value.ToString();
            txttensp.Text = datathongtin.Rows[i].Cells[1].Value.ToString();
            txtnoisx.Text = datathongtin.Rows[i].Cells[2].Value.ToString();
            txtgia.Text = datathongtin.Rows[i].Cells[3].Value.ToString();
            txtsl.Text = datathongtin.Rows[i].Cells[4].Value.ToString();
        }
        //Xóa sản phẩm
        private void btnxoa_Click(object sender, EventArgs e)
        {
            DTO_SanPham sp = new DTO_SanPham(txtmasp.Text, txttensp.Text, txtnoisx.Text, 0, 0);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (bussp.xoaSanPham(sp))
                {
                    MessageBox.Show("Xóa thành công");
                    datathongtin.DataSource = bussp.getSanPham();//làm mới datagridview
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");

                }
            }
        }
        //Sửa thông tin sp
        private void btnsua_Click(object sender, EventArgs e)
        {
            //Kiểm tra nếu có chọn table
            if (datathongtin.SelectedRows.Count > 0)
            {
                if (txtmasp.Text != "" && txttensp.Text != "" && txtnoisx.Text != "" && txtgia.Text != "" && txtsl.Text != "")
                {
                    DTO_SanPham sp = new DTO_SanPham(txtmasp.Text, txttensp.Text, txtnoisx.Text, float.Parse(txtgia.Text), int.Parse(txtsl.Text));

                    if (bussp.suaSanPham(sp)) 
                    {
                        MessageBox.Show("Sửa thành công");
                        datathongtin.DataSource = bussp.getSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Xin nhập đầy đủ thông tin");
                }
        
            }
            else
            {
                MessageBox.Show("Chọn sản phẩm cần muốn sửa từ bảng");
            }
        }
        //Tìm kiếm
        private void btnsearch_Click(object sender, EventArgs e)
        {
            datathongtin.DataSource = bussp.timSanPham(txtsearch.Text);
        }
        //Chuyển về trang chính
        private void quayVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmain f= new frmmain();
            f.Show();
            this.Hide();
        }
        //Xóa chữ khi nhập
        private void txtsearch_Enter(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }
        //Chuyển đến form Hóa Đơn
        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoadon f= new frmhoadon();
            f.Show();
            this.Hide();
        }
        //Làm mới lại bảng
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            datathongtin.DataSource = bussp.getSanPham();//làm mới datagridview
            txtmasp.Clear();
            txttensp.Clear();
            txtnoisx.Clear();
            txtgia.Clear();
            txtsl.Clear();
        }
    }
}
