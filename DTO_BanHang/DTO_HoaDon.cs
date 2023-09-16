using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanHang
{
    public class DTO_HoaDon
    {
        private string sohd;
        private DateTime ngay;
        private string manv;
        private string masp;

        public string Sohd
        {
            get
            {
                return sohd;
            }
            set
            {
                sohd = value;
            }
        }
        public DateTime Ngay
        {
            get
            {
                return ngay;
            }
            set
            {
                ngay = value;
            }
        }
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
        public string Msp
        {
            get
            {
                return masp;
            }
            set
            {
                masp = value;
            }
        }
        public DTO_HoaDon()
        {

        }
        public DTO_HoaDon(string sohd, DateTime ngay, string manv, string masp)
        {
            this.sohd = sohd;
            this.ngay = ngay;
            this.manv = manv;
            this.masp = masp;
           
        }
    }
}
