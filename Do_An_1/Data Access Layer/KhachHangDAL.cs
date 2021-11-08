using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyKhuChungCu.Entities;
using QuanLyKhuChungCu.Data_Access_Layer.Service_Interface;

namespace QuanLyKhuChungCu.Data_Access_Layer
{
    class KhachHangDAL:IKhachHangDAL
    {
        //Xác định đường dẫn của tệp dữ liệu KhachHang.txt
        private string fileName = "Data/KhachHang.txt";
        public List<KhachHang> GetAllKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();
            StreamReader fread = File.OpenText(fileName);
            string s = fread.ReadLine();
            while(s!=null)
            {
                if(s!="")
                {
                    string[] a = s.Split('#');
                    list.Add(new KhachHang(int.Parse(a[0]), a[1], a[2], int.Parse(a[3]), a[4], a[5], a[6]));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Lấy mã khách hàng của bản ghi cuối cùng phục vụ cho đánh mã tự động
        public int GetMaKH()
        {
            try
            {
                StreamReader fread = File.OpenText(fileName);
                string s = fread.ReadLine();
                string tmp = "";
                while(s!=null)
                {
                    if (s != "") tmp = s;
                    s = fread.ReadLine();
                }
                fread.Close();
                if (tmp == "") return 0;
                else
                {
                    string[] a = tmp.Split('#');
                    return int.Parse(a[0]);
                }    
            }
            catch
            {
                return 0;
            }
        }
        //Chèn một bản ghi khách hàng vào tệp
        //Mã khách hàng, họ tên, giới tính, tuổi, căn cước công dân, địa chỉ, số điện thoại
        public void Insert(KhachHang kh)
        {
            StreamWriter fwrite = File.AppendText(fileName);
            fwrite.WriteLine();
            fwrite.Write(kh.MaKH + "#" + kh.HoTen + "#" + kh.GioiTinh + "#" + kh.Tuoi + "#" + kh.CCCD + "#" + kh.DiaChi + "#" + kh.SoDT);
            fwrite.Close();
        }
        //Xoá một khách hàng khi biết mã
        public void Delete(int makh)
        {
            List<KhachHang> list = GetAllKhachHang();
            StreamWriter fwrite = File.CreateText(fileName);
            foreach (KhachHang kh in list)
            {
                if (kh.MaKH != makh)
                    Insert(kh);
            }
            fwrite.Close();
        }
        public void Update(KhachHang kh)
        {
            List<KhachHang> list = GetAllKhachHang();
            StreamWriter fwrite = File.CreateText(fileName);
            foreach(KhachHang i in list)
            {
                if (i.MaKH == kh.MaKH)
                    fwrite.WriteLine(i.MaKH + "#" + i.HoTen + "#" + i.GioiTinh + "#" + i.Tuoi + "#" + i.CCCD + "#" + i.DiaChi + "#" + i.SoDT);
                else if (i.MaKH != kh.MaKH)
                    fwrite.WriteLine(kh.MaKH + "#" + kh.HoTen + "#" + kh.GioiTinh + "#" + kh.Tuoi + "#" + kh.CCCD + "#" + kh.DiaChi + "#" + kh.SoDT);
            }    
        }
    }
}
