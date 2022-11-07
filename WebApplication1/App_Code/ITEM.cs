using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.App_Code
{
    public class ITEM
    {
        private String masanpham;
        private String tensanpham;
        private double dongia;
        private int soluong;
        private String hinhanh;
        
        public String MASANPHAM
        {
            set { this.masanpham = value; }
            get { return this.masanpham;  }
        }

        public String TENSANPHAM
        {
            set { this.tensanpham = value; }
            get { return this.tensanpham; }
        }

        public double DONGIA
        {
            set { this.dongia = value; }
            get { return this.dongia; }
        }
        public double THANHTIEN
        {
            get { return this.dongia* soluong; }
        }
        public int SOLUONG
        {
            set { this.soluong = value; }
            get { return this.soluong; }
        }

        public String HINHANH
        {
            set { this.hinhanh = value; }
            get { return this.hinhanh; }
        }

        public ITEM (String masanpham, string tensanpham,string hinhanh, double dongia, int soluong)
        {
            this.masanpham = masanpham;
            this.hinhanh = hinhanh;
            this.dongia = dongia;
            this.soluong = soluong;
            this.tensanpham = tensanpham;
        }

        public ITEM()
        {

        }
    }
}