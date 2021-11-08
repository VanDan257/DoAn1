using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Ultility;

namespace QuanLyKhuChungCu.Presentation
{
    class MenuDemo
    {
        private FormCanHo fch = new FormCanHo();
        private FormDayCanHo fdch = new FormDayCanHo();
        private FormKhachHang fkh = new FormKhachHang();
        private FormHoaDon fhd = new FormHoaDon();
        public void HienMN()
        {
            ConsoleKeyInfo key;
            string[][] mn = new string[5][];
            mn[0] = new string[] { "1.Quan ly can ho ►", "A.Nhap can ho", "B.Hien thi can ho", "C.Sua can ho", "D.Xoa 1 can ho" };
            mn[1] = new string[] { "2.Quan ly day can ho ►", "E.Nhap day can ho", "F.Hien thi day can ho", "G.Sua day can ho", "H.Xoa 1 day can ho" };
            mn[2] = new string[] { "3.Quan ly khach hang ►", "L.Nhap khach hang", "M.Hien thi khach hang", "N.Sua khach hang", "OXoa 1 khach hang" };
            mn[3] = new string[] { "4.Quan ly hoa don ►", "P.Nhap hoa don", "Q.Hien thi hoa don", "R.Sua hoa don","S.Xoa hoa don" };
            mn[4] = new string[] { "5.Thoat khoi chuong trinh" };
            int muc = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\tChuong trinh quan ly khu chung cu\n\n");
                for (int i = 0; i < mn.Length; ++i)
                {
                    Console.WriteLine("\t\t" + mn[i][0]);
                    if (i == muc)
                        for (int j = 1; j < mn[i].Length; ++j)
                            Console.WriteLine("\t\t\t" + mn[i][j]);
                }
                key = Console.ReadKey(true);
                if (key.KeyChar >= '0' && key.KeyChar <= '9')
                    muc = key.KeyChar - 49;
                else if (key.Key == ConsoleKey.X && key.Modifiers == ConsoleModifiers.Alt)
                    Environment.Exit(0);
                else
                {
                    ThucHien(key.KeyChar);
                }
            } while (true);
        }
        public void ThucHien(char ch)
        {
            switch(char.ToUpper(ch))
            {
                case 'A':Console.Clear();
                    fch.Nhap(); break;
                case 'B':Console.Clear();
                    fch.Hien(); break;
                case 'C':Console.Clear();
                    fch.SuaCanHo(); break;
                case 'D':Console.Clear();
                    fch.XoaCanHo(); break;
                case 'E':Console.Clear();
                    fdch.Nhap(); break;
                case 'F':Console.Clear();
                    fdch.Hien(); break;
                case 'G':Console.Clear();
                    fdch.SuaDayCanHo(); break;
                case 'H':Console.Clear();
                    fdch.XoaDayCanHo(); break;
                case 'L':Console.Clear();
                    fkh.Nhap(); break;
                case 'M':Console.Clear();
                    fkh.Hien(); break;
                case 'N':Console.Clear();
                    fkh.SuaKhachHang(); break;
                case 'O':Console.Clear();
                    fkh.XoaKhachHang(); break;
                case 'P':Console.Clear();
                    fhd.Nhap(); break;
                case 'Q':Console.Clear();
                    fhd.Hien();break;
                case 'R':Console.Clear();
                    fhd.SuaHoaDon(); break;
                case 'S':Console.Clear();
                    fhd.XoaHoaDon();break;
            }
        }
    }
}
