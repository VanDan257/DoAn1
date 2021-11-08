using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyKhuChungCu.Entities;
using QuanLyKhuChungCu.Data_Access_Layer.Service_Interface;

namespace QuanLyKhuChungCu.Data_Access_Layer.Service_Interface
{
    public class DayCanHoDAL:IDayCanHoDAL
    {
        //Xác định đường dẫn của tệp dữ liệu DayCanHo.txt
        private string fileName = "Data/DayCanHo.txt";
        public List<DayCanHo> GetAllDayCanHo()
        {
            List<DayCanHo> list = new List<DayCanHo>();
            StreamReader fread = File.OpenText(fileName);
            string s = fread.ReadLine();
            while(s!=null)
            {
                if(s!="")
                {
                    string[] a = s.Split('#');
                    list.Add(new DayCanHo(int.Parse(a[0]), a[1], a[2]));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Lấy mã dãy của bản ghi cuối cùng phục vụ cho đánh mã tự động
        public int GetMaDay()
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
        //Chèn một bản ghi dãy căn hộ vào tệp theo quy tắc
        //Mã dãy, tên dãy, vị trí
        public void Insert(DayCanHo dch)
        {
            int maday = GetMaDay() + 1;
            StreamWriter fwrite = File.AppendText(fileName);
            fwrite.WriteLine();
            fwrite.Write(maday + "#" + dch.TenDay + "#" + dch.ViTri);
            fwrite.Close();
        }
        public void Delete(int maday)
        {
            List<DayCanHo> list = GetAllDayCanHo();
            StreamWriter fwrite = File.CreateText(fileName);
            foreach (DayCanHo d in list)
            {
                if (d.MaDay != maday)
                    Insert(d);
            }
            fwrite.Close();
        }
        //Cập nhật một dãy căn hộ khi biết mã
        public void Update(DayCanHo dch)
        {
            List<DayCanHo> list = GetAllDayCanHo();
            StreamWriter fwrite = File.CreateText(fileName);
            foreach (DayCanHo d in list)
            {
                if (d.MaDay != dch.MaDay)
                    fwrite.WriteLine(d.MaDay + "#" + d.TenDay + "#" + d.ViTri);
                else if (d.MaDay == dch.MaDay)
                    fwrite.WriteLine(dch.MaDay + "#" + dch.TenDay + "#" + dch.ViTri);
            }
        }
    }
}