using DTO_BanHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanHang
{
    public class DAL_NhanVien:DataProvider
    {
        //Check mã nhân viên đã tồn tại chưa trước khi tạo
        public DataTable getNV()
        {
            string sql = "select * from NHANVIEN";
            return getTable(sql);
        }
        public bool checkMaNV(DTO_NhanVien nv)
        {
            string sql = string.Format("select count(*) from NHANVIEN where MANV ='{0}'", nv.Manv);
            return checkMaSp(sql);
        }
        //Lấy Manv
       public bool loginTendn(string manv)
        {
            string sql = "select MANV from NHANVIEN where MANV = @manv";
            string name = "@manv";
            return loginTendn(sql,name,manv);
        }
        //Lấy Matkhau
        public bool loginMatkhau(string mk)
        {
            string sql = "select MATKHAU from NHANVIEN where MATKHAU = @mk";
            string name = "@mk";
            return loginTendn(sql, name, mk);
        }
        //Thêm nhân viên
        public bool themNV(DTO_NhanVien nv)
        {
            string sql = "insert into NHANVIEN values(@manv,@matkhau,@hoten)";
            string[] name = {"@manv","@matkhau","@hoten"};
            object[] value = { nv.Manv,nv.Matkhau,nv.Hoten};
            return updateData(sql, name, value);
        }
        //Tìm kiếm
        public DataTable timNV(string tennv)
        {
            string sql = string.Format("select * from NHANVIEN where HOTEN Like N'%{0}'", tennv);
            return getTable(sql);
        }
        //Xóa NV
        public bool xoaNV(DTO_NhanVien nv)
        {
            string sql = string.Format("Delete from NHANVIEN where MANV='{0}'", nv.Manv);
            return updateData(sql);
        }
        //Đổi mật khẩu
        public bool doiMK(DTO_NhanVien nv)
        {
            string sql= string.Format("UPDATE NHANVIEN SET MATKHAU='{0}' WHERE MANV='{1}'",nv.Matkhau,nv.Manv);
            return updateData(sql);
        }
        //Sửa thông tin NV
        public bool sua(DTO_NhanVien nv)
        {
            string sql = string.Format("UPDATE NHANVIEN SET MATKHAU='{0}',HOTEN=N'{1}' WHERE MANV='{2}'", nv.Matkhau,nv.Hoten, nv.Manv);
            return updateData(sql);
        }
    }
}
