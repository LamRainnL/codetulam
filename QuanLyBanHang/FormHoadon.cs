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
    public partial class frmhoadon : Form
    {
        BUS_HoaDon bushd= new BUS_HoaDon();
        BUS_NhanVien busnv= new BUS_NhanVien();
        BUS_SanPham bussp= new BUS_SanPham();
        public frmhoadon()
        {
            InitializeComponent();
        }
        //Load tên nhân viên lên cbb
        public void loadManv()
        {
            cbbmanv.DataSource = busnv.getNV();
            cbbmanv.ValueMember = "MANV";
            cbbmanv.DisplayMember = "HOTEN";
        }
        //Load tên sp lên cbb
        public void loadMasp()
        {
            cbbmasp.DataSource = bussp.getSanPham();
            cbbmasp.ValueMember = "MASP";
            cbbmasp.DisplayMember = "TENSP";
        }

       //Load form
        private void frmhoadon_Load(object sender, EventArgs e)
        {
            datathongtin.DataSource= bushd.getTable();
            loadManv();
            loadMasp();
        }

        private void datathongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datathongtin.CurrentCell.RowIndex;//Trả về chỉ số dòng đang chọn
            txtsohd.Text = datathongtin.Rows[i].Cells[0].Value.ToString();
            dtp.Text = datathongtin.Rows[i].Cells[1].Value.ToString();
            cbbmanv.SelectedValue = datathongtin.Rows[i].Cells[2].Value.ToString();
            cbbmasp.SelectedValue = datathongtin.Rows[i].Cells[3].Value.ToString();
        }
        //Thêm hóa đơn
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            if (txtsohd.Text != "")
            {
                //tạo DTO
                DTO_HoaDon hd = new DTO_HoaDon(txtsohd.Text, dtp.Value, cbbmanv.SelectedValue.ToString(), cbbmasp.SelectedValue.ToString());
                //check masp
                if (bushd.checkMa(hd))
                {
                    //Them
                    if (bushd.themHoadon(hd))
                    {
                        MessageBox.Show("Thêm thành công");
                        datathongtin.DataSource = bushd.getTable();//làm mới datagridview
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng mã hóa đơn!");
                    txtsohd.Clear();
                    txtsohd.Focus();
                }
            }
            else
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin!");
            }

        }
        //Quay lại trang Sản phẩm
        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_SanPham f = new GUI_SanPham();
            f.Show();
            this.Close();
        }
        //Nút làm mới
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            datathongtin.DataSource=bushd.getTable();
            txtsohd.Clear();
           
        }
        //Xóa chữ trong ô tìm
        private void txtsearch_Enter(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }
        //Nút sửa
        private void btnsua_Click(object sender, EventArgs e)
        {
            //Kiểm tra nếu có chọn table
            if (datathongtin.SelectedRows.Count > 0)
            {
                if (txtsohd.Text != "")
                {
                    DTO_HoaDon hd = new DTO_HoaDon(txtsohd.Text, dtp.Value, cbbmanv.SelectedValue.ToString(), cbbmasp.SelectedValue.ToString());
                    if (bushd.suaHD(hd))
                    {
                        MessageBox.Show("Sửa thành công");
                        datathongtin.DataSource = bushd.getTable();
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
                MessageBox.Show("Chọn hóa đơn cần muốn sửa từ bảng");
            }
        }
        //Nút tìm
        private void btnsearch_Click(object sender, EventArgs e)
        {
            datathongtin.DataSource=bushd.tim(txtsearch.Text);
        }
    }
}
