using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyKhuChungCu.Entities;
using QuanLyKhuChungCu.Data_Access_Layer.Service_Interface;

namespace QuanLyKhuChungCu.Data_Access_Layer
{
    public class HoaDonDAL:IHoaDonDAL
    {
        //Xác định đường dẫn của tệp dữ liệu HoaDon.txt
        private string fileName = "Data/HoaDon.txt";
        public List<HoaDon> GetAllHoaDon()
        {
            List<HoaDon> list = new List<HoaDon>();
            StreamReader fread = File.OpenText(fileName);
            string s = fread.ReadLine();
            while(s!=null)
            {
                if(s!="")
                {
                    s = QuanLyKhuChungCu.Ultility.CongCu.CatXau(s);
                    string[] a = s.Split('#');
                    HoaDon h;
                    h = new HoaDon(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), a[3], int.Parse(a[4]));
                    list.Add(h);
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Lấy mã hoá đơn của bản ghi cuối cùng phục vụ cho đánh số tự động
        public int GetMaHD()
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
                    string[] a = tmp.Split("#");
                    return int.Parse(a[0]);
                }
            }
            catch
            {
                return 0;
            }
        }
        public void Insert(HoaDon hd)
        {
            int mahd = GetMaHD() + 1;
            StreamWriter fwrite = File.AppendText(fileName);
            fwrite.WriteLine();
            fwrite.Write(mahd + "#" + hd.MaKH + "#" + hd.SoNha + "#" + QuanLyKhuChungCu.Ultility.CongCu.ChuanHoaXau(hd.NgayThanhToan) + "#" + hd.TongTien);
            fwrite.Close();
        }
        public void Delete(int mahd)
        {
            List<HoaDon> list = GetAllHoaDon();
            StreamWriter fwrite = File.CreateText(fileName);
            foreach (HoaDon hd in list)
            {
                if (hd.MaHD != mahd)
                    Insert(hd);
            }
            fwrite.Close();
        }
        public void Update(HoaDon hd)
        {
            List<HoaDon> list = GetAllHoaDon();
            StreamWriter fwrite = File.CreateText(fileName);
            foreach (HoaDon i in list)
            {
                if(i.MaHD==hd.MaHD)
                    fwrite.Write(i.MaHD + "#" + i.MaKH + "#" + i.SoNha + "#" + i.NgayThanhToan + "#" + i.TongTien);
                else if(i.MaHD!=hd.MaHD)
                    fwrite.Write(hd.MaHD + "#" + hd.MaKH + "#" + hd.SoNha + "#" + hd.NgayThanhToan + "#" + hd.TongTien);
            }
        }
    }
}
