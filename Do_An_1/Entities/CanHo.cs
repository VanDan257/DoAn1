using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhuChungCu.Entities
{
    public class CanHo
    {
        //các thành phần dữ liệu
        private int sonha;
        private double dientich;
        private double giaban;
        private string tinhtrang;
        private int maday;
        public int SoNha
        {
            get { return sonha; }
            set
            {
                if (value >= 1) sonha = value;
            }
        }
        public double DienTich
        {
            get { return dientich; }
            set
            {
                if (value >= 1) dientich = value;
            }
        }
        public double GiaBan
        {
            get { return giaban; }
            set
            {
                if (value >= 1) giaban = value;
            }
        }
        public string TinhTrang
        {
            get { return tinhtrang; }
            set
            {
                if (value != "") tinhtrang = value;
            }
        }
        public int MaDay
        {
            get { return maday; }
            set
            {
                if (value >= 1) maday = value;
            }
        }
        //phương thức khởi tạo không tham số
        public CanHo() { }
        //phương thức khởi tạo có tham số
        public CanHo(int sonha, double dientich, double giaban, string tinhtrang, int maday)
        {
            this.sonha = sonha;
            this.dientich = dientich;
            this.giaban = giaban;
            this.tinhtrang = tinhtrang;
            this.maday = maday;
        }
        public CanHo(double dientich, double giaban, string tinhtrang, int maday)
        {
            this.dientich = dientich;
            this.giaban = giaban;
            this.tinhtrang = tinhtrang;
            this.maday = maday;
        }
        //phương thức khởi tạo sao chép
        public CanHo(CanHo t)
        {
            this.sonha = t.sonha;
            this.dientich = t.dientich;
            this.giaban = t.giaban;
            this.tinhtrang = t.tinhtrang;
            this.maday = t.maday;
        }
    }
}

