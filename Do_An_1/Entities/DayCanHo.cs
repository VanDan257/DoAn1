using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhuChungCu.Entities
{
    public class DayCanHo
    {
        private int maday;
        private string tenday;
        private string vitri;
        public int MaDay
        {
            get { return maday; }
            set { if (value >= 1) maday = value; }
        }
        public string TenDay
        {
            get { return tenday; }
            set
            {
                if (value == "") tenday = value;
            }
        }
        public string ViTri
        {
            get { return vitri; }
            set
            {
                if (value == "") vitri = value;
            }
        }
        public DayCanHo() { }
        public DayCanHo(int maday, string tenday, string vitri)
        {
            this.maday = maday;
            this.tenday = tenday;
            this.vitri = vitri;
        }
        public DayCanHo(string tenday, string vitri)
        {
            this.tenday = tenday;
            this.vitri = vitri;
        }
        public DayCanHo(DayCanHo d)
        {
            this.maday = d.maday;
            this.tenday = d.tenday;
            this.vitri = d.vitri;
        }
    }
}
