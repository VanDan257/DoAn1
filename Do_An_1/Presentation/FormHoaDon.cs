using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Business;
using QuanLyKhuChungCu.Entities;
using QuanLyKhuChungCu.Business.Service_Interface;

namespace QuanLyKhuChungCu.Presentation
{
    public class FormHoaDon : FormDefault
    {
        public void Nhap()
        {
            char kt;
            HoaDon hd = new HoaDon();
            do
            {
                Console.Clear();
                Console.SetCursorPosition(0, 15);
                Hien(canho.GetAllCanHo(), "\t\tDANH SACH CAC CAN HO");
                Console.SetCursorPosition(70, 15);
                Hien(khachhang.GetAllKhachHang(), "\t\tDANH SACH KHACH HANG");
                for (int i = 15; i < 30; i++)
                {
                    Console.SetCursorPosition(65, i);
                    Console.WriteLine("|");
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("\t\tNHAP THONG TIN HOA DON:");
                Console.WriteLine("------------------------------------------------------");
                Console.Write("Ma khach hang: "); hd.MaKH = int.Parse(Console.ReadLine());
                do
                {

                    foreach (KhachHang kh in khachhang.GetAllKhachHang())
                    {
                        if (hd.MaKH != kh.MaKH)
                            Console.WriteLine("Ma khach hang khong ton tai!");
                        return;
                    }
                } while (false);
                Console.Write("So nha duoc mua: "); hd.SoNha = int.Parse(Console.ReadLine());
                do
                {

                    foreach (CanHo ch in canho.GetAllCanHo())
                    {
                        if (hd.SoNha != ch.SoNha)
                            Console.WriteLine("So nha khong ton tai!");
                        return;
                    }
                } while (false);
                Console.Write("Ngay thanh toan: "); hd.NgayThanhToan = Console.ReadLine();
                foreach(CanHo i in canho.GetAllCanHo())
                {
                    if (hd.SoNha == i.SoNha)
                        hd.TongTien = i.GiaBan;
                }    
                hoadon.Insert(hd);
                Console.Write("Ban co muon nhap tiep khong(Y/N): ");
                kt = char.Parse(Console.ReadLine());

            } while (char.ToUpper(kt) == 'Y');
        }
        public void Hien()
        {
            Hien(hoadon.GetAllHoaDon(), "\n\t\tDANH SACH HOA DON");
            Console.Write("Nhan phim enter de tiep tuc");
            Console.ReadLine();
        }
        public void SuaHoaDon()
        {
            HoaDon hd = new HoaDon();
            Console.Write("Nhap ma hoa don can sua: "); hd.MaHD = int.Parse(Console.ReadLine());
            Console.Write("Nhap lai ma khach hang: "); hd.MaKH = int.Parse(Console.ReadLine());
            Console.Write("Nhap lai so nha: "); hd.SoNha = int.Parse(Console.ReadLine());
            Console.Write("Nhap lai ngay thanh toan: "); hd.NgayThanhToan = Console.ReadLine();
            Hien(hoadon.GetAllHoaDon(), "\n\t\tDANH SACH HOA DON");
            hoadon.Update(hd);
            Console.Clear();
            Hien(hoadon.GetAllHoaDon(), "\n\t\tDANH SACH HOA DON SAU KHI SUA");
            Console.Write("Nhan phim enter de tiep tuc!");
        }
        public void XoaHoaDon()
        {
            int mahd;
            Console.Write("Nhap ma hoa don ban muon xoa: "); mahd = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(0, 3);
            Hien(hoadon.GetAllHoaDon(), "\n\t\tDANH SACH HOA DON");
            hoadon.Delete(mahd);
            Console.Clear();
            Hien(hoadon.GetAllHoaDon(), "\n\t\tDANH SACH HOA DON SAU KHI XOA");
            Console.WriteLine("Nhan phim enter de tiep tuc!");
        }
    }
}
