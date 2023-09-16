using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanHang
{
    public class DTO_NhanVien
    {
       private string manv;
       private string matkhau;
       private string hoten;

        public string Manv
        {
            get
            {
                return manv;
            }
            set
            {
                manv = value;
            }
        }
        public string Hoten
        {
            get
            {
                return hoten;

            }
            set 
            {   
                hoten = value; 
            }
        }
        public string Matkhau
        {
            get
            {
                return matkhau;
            }
            set
            {
                matkhau = value;
            }

        }
        //Hàm tạo
        public DTO_NhanVien()
        {

        }
        public DTO_NhanVien(string manv,string matkhau ,string hoten="")
        {
            this.manv = manv;
            this.matkhau = matkhau;
            this.hoten = hoten;
        }
    }
}
