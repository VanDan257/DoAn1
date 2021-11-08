using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhuChungCu.Entities
{
    public class KhachHang
    {
        //các thành phần dữ liệu
        private int makh;
        private string hoten;
        private string gioitinh;
        private int tuoi;
        private string cccd;
        private string diachi;
        private string sodt;

        public int MaKH
        {
            get { return makh; }
            set
            {
                if (value != 0) makh = value;
            }
        }
        public string HoTen
        {
            get { return hoten; }
            set
            {
                if (value != "") hoten = value;
            }
        }
        public string GioiTinh
        {
            get { return gioitinh; }
            set
            {
                if (value == "nam" || value == "nu") gioitinh = value;
            }
        }
        public int Tuoi
        {
            get { return tuoi; }
            set
            {
                if (value >= 16) tuoi = value;
            }
        }
        public string CCCD
        {
            get { return cccd; }
            set { cccd = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string SoDT
        {
            get { return sodt; }
            set { sodt = value; }
        }
        //phương thức khởi tạo không chưa tham số
        public KhachHang() { }

        //phương thức khởi tạo chứa tham số
        public KhachHang(int makh, string hoten, string gioitinh, int tuoi, string cccd, string diachi, string sdt)
        {
            this.makh = makh;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.tuoi = tuoi;
            this.cccd = cccd;
            this.diachi = diachi;
            this.sodt = sdt;
        }
        public KhachHang(string hoten, string gioitinh, int tuoi, string cccd, string diachi, string sdt)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.tuoi = tuoi;
            this.cccd = cccd;
            this.diachi = diachi;
            this.sodt = sdt;
        }
        public KhachHang(KhachHang kh)
        {
            this.makh = kh.makh;
            this.hoten = kh.hoten;
            this.gioitinh = kh.gioitinh;
            this.tuoi = kh.tuoi;
            this.cccd = kh.cccd;
            this.diachi = kh.diachi;
            this.sodt = kh.sodt;
        }
    }
}
