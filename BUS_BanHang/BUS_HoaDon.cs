using DAL_BanHang;
using DTO_BanHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BanHang
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dalhoadon= new DAL_HoaDon();

        public DataTable getTable()
        {
            return dalhoadon.getHoaDon();
        }
        public bool themHoadon(DTO_HoaDon hd)
        {
            return dalhoadon.themSanPham(hd);
        }
        public bool checkMa(DTO_HoaDon hd)
        {
            return dalhoadon.checkMa(hd);
        }
        public bool suaHD(DTO_HoaDon hd)
        {
            return dalhoadon.suaHD(hd);
        }
        public DataTable tim(string tensp)
        {
            return dalhoadon.tim(tensp);
        }
        public bool xoaAll()
        {
            return dalhoadon.xoaAll();
        }
        public bool taoTable()
        {
            return dalhoadon.taoTable();
        }
        public bool taoKey1()
        {
            return dalhoadon.taoKeyNV();
        }
        public bool taoKey2()
        {
            return dalhoadon.taoKeySP();
        }
    }
}
