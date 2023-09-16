using DAL_BanHang;
using DTO_BanHang;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BanHang
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalnhanvien= new DAL_NhanVien();

        public DataTable getNV()
        {
            return dalnhanvien.getNV();
        }
        public bool checkMaNV(DTO_NhanVien nv)
        {
            return dalnhanvien.checkMaNV(nv);
        }
        public bool themNV(DTO_NhanVien nv)
        {
            return dalnhanvien.themNV(nv);
        }
        //Check Đăng nhập
        public bool loginTendn(string manv)
        {
            return dalnhanvien.loginTendn(manv);
        }
        public bool loginMatkhau(string mk)
        {
            return dalnhanvien.loginMatkhau(mk);
        }
        public DataTable timNV(string tennv)
        {
            return dalnhanvien.timNV(tennv);
        }
        public bool xoaNV(DTO_NhanVien nv)
        {
            return dalnhanvien.xoaNV(nv);
        }
        public bool doiMK(DTO_NhanVien nv)
        {
            return dalnhanvien.doiMK(nv);
        }
        public bool sua(DTO_NhanVien nv)
        {
            return dalnhanvien.sua(nv);
        }
    }
}
