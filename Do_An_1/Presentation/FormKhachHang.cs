using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Business;
using QuanLyKhuChungCu.Entities;
using QuanLyKhuChungCu.Business.Service_Interface;

namespace QuanLyKhuChungCu.Presentation
{
    public class FormKhachHang : FormDefault
    {
        public void Nhap()
        {
            char kt;
            KhachHang kh = new KhachHang();
            do
            {
                Console.Clear();
                Console.WriteLine("\t\tNHAP THONG TIN CHO KHACH HANG: ");
                Console.Write("Ten khach hang: "); kh.HoTen = Console.ReadLine();
                Console.Write("Gioi tinh: "); kh.GioiTinh = Console.ReadLine();
                do
                {
                    Console.Write("Tuoi: ");
                    kh.Tuoi = int.Parse(Console.ReadLine());
                    if (kh.Tuoi < 16) Console.WriteLine("Khach hang chua du tuoi de mua nha!\nTuoi phai lon hon 16");
                } while (kh.Tuoi < 16);
                Console.Write("So can cuoc cong dan: "); kh.CCCD = Console.ReadLine();
                Console.Write("Dia chi: "); kh.DiaChi = Console.ReadLine();
                Console.Write("So dien thoai: "); kh.SoDT = Console.ReadLine();
                Console.Write("So nha cua can ho khach hang mua: ");
                Console.Write("Ban co muon nhap tiep khong: ");
                kt = char.Parse(Console.ReadLine());
                Console.SetCursorPosition(0, 8);
                Hien(canho.GetAllCanHo(), "\n\t\tDANH SACH CAC CAN HO CUA KHU CHUNG CU: ");
            } while (char.ToUpper(kt) == 'Y');
        }
        public void Hien()
        {
            Hien(khachhang.GetAllKhachHang(), "\n\t\tDANH SACH KHACH HANG");
            Console.Write("Nhan phim enter de tiep tuc");
            Console.ReadLine();
        }
        public void XoaKhachHang()
        {
            int makh;
            Console.Write("Nhap ma khach hang can xoa: ");
            makh = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(0, 3);
            Hien(khachhang.GetAllKhachHang(), "\n\t\tDANH SACH KHACH HANG");
            khachhang.Delete(makh);
            Console.Clear();
            Hien(khachhang.GetAllKhachHang(), "\n\t\tDANH SACH KHACH HANG");
            Console.Write("Nhan phim enter de tiep tuc");
            Console.ReadLine();
        }
        public void SuaKhachHang()
        {
            List<KhachHang> list = khachhang.GetAllKhachHang();
            Hien(khachhang.GetAllKhachHang(), "\n\t\tDANH SACH KHACH HANG");
            KhachHang kh = new KhachHang();
            Console.Write("Nhap ma khach hang can sua: ");
            Console.Write("Nhap lai ten khach hang: ");
            kh.HoTen = Console.ReadLine();
            Console.Write("Nhap lai gioi tinh: ");
            kh.GioiTinh = Console.ReadLine();
            Console.Write("Nhap lai tuoi: ");
            kh.Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap lai so can cuoc cong dan: ");
            kh.CCCD = Console.ReadLine();
            Console.Write("Nhap lai dia chi: ");
            kh.DiaChi = Console.ReadLine();
            Console.Write("Nhap lai so dien thoai: ");
            kh.SoDT = Console.ReadLine();
            khachhang.Update(kh);
            Console.Clear();
            Hien(khachhang.GetAllKhachHang(), "\n\t\tDANH SACH KHACH HANG");
            Console.Write("Nhan phim enter de tiep tuc");
        }
    }
}
