using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanHang;
namespace DAL_BanHang
{
    public class DAL_SanPham:DataProvider
    {
        //Đẩy dữ liệu lên form
        public DataTable getSanPham()
        {
            string sql = "select * from SANPHAM";
            return getTable(sql);
        }
        //Check MaSP
        public bool checkMaSp(DTO_SanPham sp)
        {
            string sql= string.Format("select count(*) from SANPHAM where MASP ='{0}'", sp.MaSp);
            return checkMaSp(sql);
        }
        //Thêm sản phẩm
        public bool themSanPham(DTO_SanPham sp)
        {
            
            string sql = "insert into SANPHAM values(@masp,@tensp,@noisx,@gia,@soluong)";
            string[] name = {"@masp","@tensp","@noisx","@gia","@soluong" };
            object[] value = { sp.MaSp,sp.Tensp,sp.Noisx,sp.Gia,sp.Soluong};
            return updateData(sql, name, value);
            
        }
        //Xóa sản phẩm
        public bool xoaSanPham(DTO_SanPham sp)
        {
            string sql = string.Format("Delete from SANPHAM where MASP='{0}'", sp.MaSp);
            return updateData(sql);
        }
        //Sửa thông tin sản phẩm
        public bool suaSanPham(DTO_SanPham sp)
        {
            string sql = string.Format("UPDATE SANPHAM SET TENSP = '{0}', NOISX = '{1}',GIA = '{2}',SOLUONG = '{3}' WHERE MASP='{4}'", sp.Tensp, sp.Noisx, sp.Gia,sp.Soluong,sp.MaSp);
            return updateData(sql);
        }
        //Tìm kiếm sản phẩm
        public bool timSanPham(DTO_SanPham sp)
        {
            string sql = string.Format("select * from SANPHAM where TENSP Like N'%{0}'", sp.Tensp);
            return updateData(sql);
        }
    }
}
