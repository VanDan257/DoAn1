using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyKhuChungCu.Entities;
using QuanLyKhuChungCu.Data_Access_Layer.Service_Interface;

namespace QuanLyKhuChungCu.Data_Access_Layer
{
    public class CanHoDAL : ICanHoDAL
    {
        //Xác định đường dẫn của tệp dữ liệu CanHo.txt
        private string fileName = "Data/CanHo.txt";
        public List<CanHo> GetAllCanHo()
        {
            List<CanHo> list = new List<CanHo>();
            StreamReader fread = File.OpenText(fileName);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new CanHo(int.Parse(a[0]), double.Parse(a[1]), double.Parse(a[2]), a[3], int.Parse(a[4])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Lấy sonha của bản ghi cuối cùng phục vụ cho đánh số nhà tự động
        public int GetSoNha()
        {
            try
            {
                StreamReader fread = File.OpenText(fileName);
                string s = fread.ReadLine();
                string tmp = "";
                while (s != null)
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
        //Chèn một bản ghi căn hộ vào tệp theo quy tắc
        //Số nhà, diện tích, giá bán, trình trạng, mã dãy
        public void Insert(CanHo ch)
        {
            int sonha = GetSoNha() + 1;
            StreamWriter fwrite = File.AppendText(fileName);
            fwrite.WriteLine();
            fwrite.Write(sonha + "#" + ch.DienTich + "#" + ch.GiaBan + "#" + ch.TinhTrang + "#" + ch.MaDay);
            fwrite.Close();
        }
        //Xoá một căn hộ khi biết số nhà
        public void Delete(int sonha)
        {
            List<CanHo> list = GetAllCanHo();
            StreamWriter fwrite = File.CreateText(fileName);
            foreach (CanHo c in list)
            {
                if (c.SoNha != sonha)
                    Insert(c);
            }
            fwrite.Close();
        }
        //Cập nhật một căn hộ khi biết mã
        public void Update(CanHo ch)
        {
            List<CanHo> list = GetAllCanHo();
            StreamWriter fwrite = File.CreateText(fileName);
            foreach (CanHo i in list)
            {
                if (i.SoNha != ch.SoNha)
                    fwrite.WriteLine(i.SoNha + "#" + i.DienTich + "#" + i.GiaBan + "#" + i.TinhTrang + "#" + i.MaDay);
                else if (i.SoNha == ch.SoNha)
                    fwrite.WriteLine(ch.SoNha + "#" + ch.DienTich + "#" + ch.GiaBan + "#" + ch.TinhTrang + "#" + ch.MaDay);
            }
        }
    }
}