using DTO_BanHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanHang
{
    public class DAL_HoaDon:DataProvider
    {
        public DataTable getHoaDon()
        {
            string sql = "select * from HOADON";
            return getTable(sql);
        }
        //Thêm sản phẩm
        public bool themSanPham(DTO_HoaDon hd)
        {

            string sql = "insert into HOADON values(@sohd,@ngayhd,@manv,@masp)";
            string[] name = { "@sohd", "@ngayhd", "@manv", "@masp" };
            object[] value = { hd.Sohd, hd.Ngay, hd.Manv, hd.Msp };
            return updateData(sql, name, value);

        }
        //Check MaSP
        public bool checkMa(DTO_HoaDon hd)
        {
            string sql = string.Format("select count(*) from HOADON where SOHD ='{0}'", hd.Sohd);
            return checkMaSp(sql);
        } 
        //Sửa thông tin hóa đơn
        public bool suaHD(DTO_HoaDon hd)
        {
            string sql = string.Format("UPDATE HOADON SET NGAYHD =@ngay,MANV =@manv,MASP =@masp WHERE SOHD='{0}'",hd.Sohd);
            string[] name = {"@ngay","@manv","@masp" };
            object[] value = {hd.Ngay,hd.Manv, hd.Msp};
            return updateData(sql,name,value);
        }
        //Tìm kiếm
        public DataTable tim(string tensp)
        {
            string sql = string.Format("SELECT SOHD,NGAYHD,MANV,HOADON.MASP FROM HOADON,SANPHAM WHERE HOADON.MASP=SANPHAM.MASP AND SANPHAM.TENSP Like N'%{0}'", tensp);
            return getTable(sql);
        }
        //Xóa bảng
        public bool xoaAll()
        {
            string sql = "DROP TABLE HOADON";
            return Table(sql);
        }
        //Tạo bảng
        public bool taoTable()
        {
            string sql = "CREATE TABLE HOADON(SOHD CHAR(10) PRIMARY KEY,NGAYHD DATETIME NOT NULL,MANV CHAR(10) NOT NULL,MASP CHAR(10) NOT NULL)";
            return Table(sql);
        }
        //tạo khóa ngoại với bảng NV
        public bool taoKeyNV()
        {
            string sql="";
            if (taoTable())
            {
                sql = "ALTER TABLE HOADON ADD CONSTRAINT FK_MANV  FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)";
            }
            return Table(sql);


        }
        //tạo khóa ngoại với bảng SP
        public bool taoKeySP()
        {
            string sql = "";
            if (taoTable())
            {
                sql = "ALTER TABLE HOADON ADD CONSTRAINT FK_MASP  FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP)";
            }
            return Table(sql);
        }
    }
}
