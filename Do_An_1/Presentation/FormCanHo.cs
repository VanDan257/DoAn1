using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Business;
using QuanLyKhuChungCu.Entities;
using QuanLyKhuChungCu.Business.Service_Interface;

namespace QuanLyKhuChungCu.Presentation
{
    class FormCanHo : FormDefault
    {
        public void Nhap()
        {
            char kt;
            CanHo ch = new CanHo();
            do
            {
                Console.Clear();
                Console.SetCursorPosition(0, 20); Hien(daycanho.GetAllDayCanHo(), "\t\tDanh sach ma day can ho");
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("\t\tNHAP THONG TIN CAN HO:");
                Console.WriteLine("------------------------------------------------------");
                Console.Write("Dien tich:       m^2");
                Console.SetCursorPosition(11, 2);
                ch.DienTich = double.Parse(Console.ReadLine());
                Console.Write("Gia ban:        trieu vnd");
                Console.SetCursorPosition(9, 3);
                ch.GiaBan = double.Parse(Console.ReadLine());
                Console.Write("Trang thai: "); ch.TinhTrang = Console.ReadLine();
                Console.Write("Ma day: "); ch.MaDay = int.Parse(Console.ReadLine());
                canho.Insert(ch);
                Hien(canho.GetAllCanHo(), "\n\t\tDANH SACH CAC CAN HO DA NHAP");
                Console.Write("Ban co muon nhap tiep khong(Y/N): ");
                kt = char.Parse(Console.ReadLine());
                if (char.ToUpper(kt) == 'N') return;
            } while (true);
        }
        public void Hien()
        {
            Hien(canho.GetAllCanHo(), "\n\t\tDANH SACH CAC CAN HO LA: ");
            Console.Write("Nhan phim enter de tiep tuc");
            Console.ReadKey();
        }
        public void SuaCanHo()
        {
            Hien(canho.GetAllCanHo(), "\n\t\tDANH SACH CAC CAN HO LA:\n ");
            CanHo c = new CanHo();
            Console.Write("Nhap so nha cua can ho can sua: "); c.SoNha = int.Parse(Console.ReadLine());
            Console.Write("Nhap lai dien tich: "); c.DienTich = double.Parse(Console.ReadLine());
            Console.Write("Nhap lai gia ban: "); c.GiaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap lai tinh trang: "); c.TinhTrang = Console.ReadLine();
            Console.Write("Nhap lai ma day: "); c.MaDay = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(0, 7); Hien(daycanho.GetAllDayCanHo(), "\t\tDanh sach ma day can ho");
            canho.Update(c);
            Console.Clear();
            Hien(canho.GetAllCanHo(), "\n\t\tDANH SACH CAC DAY CAN HO SAU KHI SUA LA: ");
            Console.Write("Nhan phim enter de tiep tuc!");
        }
        public void XoaCanHo()
        {
            int sonha;
            Hien(canho.GetAllCanHo(), "\n\t\ttDANH SACH CAC CAN HO LA: ");
            Console.Write("Nhap so nha ban muon xoa: "); sonha = int.Parse(Console.ReadLine());
            canho.Delete(sonha);
            Console.Clear();
            Hien(canho.GetAllCanHo(), "\n\t\tDANH SACH CAC CAN HO SAU KHI XOA LA: ");
            Console.Write("Nhan phim enter de tiep tuc!");
        }
    }
}
