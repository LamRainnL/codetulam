using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_BanHang;
using DTO_BanHang;
namespace BUS_BanHang
{
    public class BUS_SanPham
    {
        DAL_SanPham dalsanpham= new DAL_SanPham();
        public DataTable getSanPham()
        {
            return dalsanpham.getSanPham();
        }
        public bool themSanPham(DTO_SanPham sp)
        {
            return dalsanpham.themSanPham(sp);
        }
        public bool checkMaSp(DTO_SanPham sp)
        {
            return dalsanpham.checkMaSp(sp);
        }
        public bool xoaSanPham(DTO_SanPham sp)
        {
            return dalsanpham.xoaSanPham(sp);
        }
        //Sửa sp
        public bool suaSanPham(DTO_SanPham sp)
        {
            return dalsanpham.suaSanPham(sp);
        }
        //Tìm sp
        public bool timSanPham(DTO_SanPham sp)
        {
            return dalsanpham.timSanPham(sp);
        }
    }

}
