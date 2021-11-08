using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhuChungCu.Entities
{
    public class HoaDon
    {
        private int mahd, makh, sonha;
        private string ngaythanhtoan;
        private double tongtien;
        public int MaHD
        {
            get { return mahd; }
            set
            {
                if (value >= 1) mahd = value;
            }
        }
        public int MaKH
        {
            get { return makh; }
            set
            {
                if (value >= 1) makh = value;
            }
        }
        public int SoNha
        {
            get { return sonha; }
            set { if (value >= 1) sonha = value; }
        }
        public double TongTien
        {
            get { return tongtien; }
            set
            {
                if (value >= 1) tongtien = value;
            }
        }
        public string NgayThanhToan
        {
            get { return ngaythanhtoan; }
            set
            {
                ngaythanhtoan = value;
            }
        }
        public HoaDon() { }
        public HoaDon(int mahd, int makh, int sonha, string ngaythanhtoan, int tongtien)
        {
            this.mahd = mahd;
            this.makh = makh;
            this.sonha = sonha;
            this.ngaythanhtoan = ngaythanhtoan;
            this.tongtien = tongtien;
        }
        public HoaDon(HoaDon hd)
        {
            this.mahd = hd.mahd;
            this.makh = hd.makh;
            this.sonha = hd.sonha;
            this.ngaythanhtoan = hd.ngaythanhtoan;
            this.tongtien = hd.tongtien;
        }
    }
}
