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
    public partial class frmnhanvien : Form
    {
        BUS_NhanVien busnv= new BUS_NhanVien();
        BUS_HoaDon bushd= new BUS_HoaDon();
        public frmnhanvien()
        {
            InitializeComponent();
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            datanhanvien.DataSource = busnv.getNV();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            datanhanvien.DataSource=busnv.timNV(txtsearch.Text);
        }
        //Xóa nhân viên

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien(txtmanv.Text,txtmatkhau.Text,txtten.Text);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (busnv.xoaNV(nv))
                {
                    MessageBox.Show("Xóa thành công");
                    datanhanvien.DataSource = busnv.getNV();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");

                }
            }
        }
        //Dẩy dữ liệu lên
        private void datanhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = datanhanvien.CurrentCell.RowIndex;//Trả về chỉ số dòng đang chọn
            txtmanv.Text = datanhanvien.Rows[i].Cells[0].Value.ToString();
            txtmatkhau.Text = datanhanvien.Rows[i].Cells[1].Value.ToString();
            txtten.Text = datanhanvien.Rows[i].Cells[2].Value.ToString();
         
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmain f= new frmmain();
            f.Show();
            this.Hide();
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            datanhanvien.DataSource=busnv.getNV();
            txtmanv.Clear();
            txtmatkhau.Clear();
            txtten.Clear();
        }

        private void tínhNăngAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Đây là tính năng xóa dữ liệu bảng Hóa ĐƠn! Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                if (bushd.xoaAll() == false)
                {
                    if (bushd.taoTable()==false)
                    {
                        if (bushd.taoKey1()==false)
                        {   
                            if (bushd.taoKey2()==false)
                            {
                                MessageBox.Show("Đã xóa dữ liệu bảng Hóa Đơn thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Tạo khóa SP không thành công!");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Tạo khóa NV không thành công!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tạo bảng không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text != "" && txtten.Text != "" && txtmatkhau.Text != "")
            {
                DTO_NhanVien nv = new DTO_NhanVien(txtmanv.Text, txtmatkhau.Text, txtten.Text);
                if (busnv.checkMaNV(nv))
                {
                    if (busnv.themNV(nv))
                    {
                        MessageBox.Show("Tạo tài khoản thành công");
                        datanhanvien.DataSource = busnv.getNV();
                    }
                    else
                    {
                        MessageBox.Show("Tạo không thành công!");
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
        //Sửa thông tin nhân viên
        private void btnsua_Click(object sender, EventArgs e)
        {
            //Kiểm tra nếu có chọn table
            if (datanhanvien.SelectedRows.Count > 0)
            {
                if (txtmanv.Text != "" && txtmanv.Text != "" && txtten.Text != "")
                {
                    DTO_NhanVien nv = new DTO_NhanVien(txtmanv.Text, txtmatkhau.Text, txtten.Text);

                    if (busnv.sua(nv))
                    {
                        MessageBox.Show("Sửa thành công");
                        datanhanvien.DataSource = busnv.getNV();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập chưa đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Chọn sản phẩm cần muốn sửa từ bảng");
            }
        }
    }
}
