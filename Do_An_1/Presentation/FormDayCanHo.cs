using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Business;
using QuanLyKhuChungCu.Entities;
using QuanLyKhuChungCu.Business.Service_Interface;

namespace QuanLyKhuChungCu.Presentation
{
    public class FormDayCanHo:FormDefault
    {
        public void Nhap()
        {
            DayCanHo dch = new DayCanHo();
            char kt;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\tNHAP THONG TIN CHO DAY CAN HO");
                Console.WriteLine("------------------------------------------------------");
                Console.Write("Ten day: "); dch.TenDay = Console.ReadLine();
                Console.Write("Vi tri: "); dch.ViTri = Console.ReadLine();
                daycanho.Insert(dch);
                Console.Write("Ban co muon nhap tiep khong(Y/N): "); kt = char.Parse(Console.ReadLine());
                Hien(daycanho.GetAllDayCanHo(), "\n\t\tDANH SACH DAY CAN HO HIEN CO CUA KHU CHUNG CU");
            } while (char.ToUpper(kt) == 'Y');
        }
        public void Hien()
        {
            Hien(daycanho.GetAllDayCanHo(), "\n\t\tDANH SACH CAC DAY CAN HO LA: ");
            Console.Write("Nhan phim enter de tiep tuc: ");
            Console.ReadLine();
        }
        public void SuaDayCanHo()
        {
            Hien(daycanho.GetAllDayCanHo(), "\n\t\tDANH SACH CAC DAY CAN HO: ");
            DayCanHo d = new DayCanHo();
            Console.Write("Nhap ma day can sua: "); d.MaDay = int.Parse(Console.ReadLine());
            Console.Write("Nhap lai ten day: "); d.TenDay = Console.ReadLine();
            Console.Write("Nhap lai vi tri: "); d.ViTri = Console.ReadLine();
            daycanho.Update(d);
            Console.Clear();
            Hien(daycanho.GetAllDayCanHo(), "\n\t\tDANH SACH CAC DAY CAN HO SAU KHI SUA LA: ");
            Console.Write("Nhan phim enter de tiep tuc");

        }
        public void XoaDayCanHo()
        {
            int maday;
            Hien(daycanho.GetAllDayCanHo(), "\n\t\tDANH SACH CAC DAY CAN HO LA: ");
            Console.Write("Nhap ma day can xoa: "); maday = int.Parse(Console.ReadLine());
            daycanho.Delete(maday);
            Console.Clear();
            Hien(daycanho.GetAllDayCanHo(), "\n\t\tDANH SACH CAC DAY CAN HO SAU KHI XOA LA: ");
            Console.Write("Nhan phim enter de tiep tuc!");
        }
    }
}
