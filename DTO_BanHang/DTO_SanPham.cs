using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanHang
{
    public class DTO_SanPham
    {
        private string masp;
        private string tensp;
        private string noisx;
        private float gia;
        private int soluong;

        public string MaSp
        {
            get
            {
                return masp;
            }
            set
            {
                masp= value;
            }
        }
        public string Tensp
        {
            get 
            { 
                return tensp;
            }
            set 
            { 
                tensp= value;
            }
        }
        public string Noisx
        {
            get
            {
                return noisx;
            }
            set 
            
            {
                noisx= value; 
            }
        }
        public float Gia
        {
            get
            {
                return gia;
            }
            set
            {
                gia = value;
            }
        }
        public int Soluong
        {
            get
            {
                return soluong;
            }
            set
            {
                soluong = value;
            }
        }
        //Hàm tạo
        public DTO_SanPham()
        {

        }
        public DTO_SanPham(string masp, string tensp, string noisx, float gia, int soluong)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.noisx = noisx;
            this.gia = gia;
            this.soluong = soluong;
        }
    }
}
