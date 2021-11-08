using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Business;
using QuanLyKhuChungCu.Entities;
using QuanLyKhuChungCu.Business.Service_Interface;

namespace QuanLyKhuChungCu.Presentation
{
    public class FormDefault
    {
        protected ICanHoBLL canho = new CanHoBLL();
        protected IDayCanHoBLL daycanho = new DayCanHoBLL();
        protected IKhachHangBLL khachhang = new KhachHangBLL();
        protected IHoaDonBLL hoadon = new HoaDonBLL();
        public virtual void Hien(List<CanHo> list, string tieude)
        {
            Console.WriteLine(tieude);
            Console.WriteLine("------------------------------------------------------");
            for (int i = list.Count - 1; i >= 0; --i)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", list[i].SoNha, list[i].DienTich, list[i].GiaBan, list[i].TinhTrang, list[i].MaDay);
        }
        public virtual void Hien(List<DayCanHo> list, string tieude)
        {
            Console.WriteLine(tieude);
            Console.WriteLine("------------------------------------------------------");
            for (int i = list.Count - 1; i >= 0; --i)
                Console.WriteLine("{0}\t{1}\t{2}", list[i].MaDay, list[i].TenDay, list[i].ViTri);
        }
        public virtual void Hien(List<KhachHang> list, string tieude)
        {
            Console.WriteLine(tieude);
            Console.WriteLine("------------------------------------------------------");
            for (int i = list.Count - 1; i >= 0; --i)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", list[i].MaKH, list[i].HoTen, list[i].GioiTinh, list[i].Tuoi, list[i].CCCD, list[i].DiaChi, list[i].SoDT);
        }
        public virtual void Hien(List<HoaDon> list, string tieude)
        {
            Console.WriteLine(tieude);
            Console.WriteLine("------------------------------------------------------");
            foreach (HoaDon hd in list)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", hd.MaHD, hd.MaKH, hd.SoNha, hd.NgayThanhToan, hd.TongTien);
            }
        }
    }
}
