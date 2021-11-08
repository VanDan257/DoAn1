using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Business.Service_Interface;
using QuanLyKhuChungCu.Data_Access_Layer.Service_Interface;
using QuanLyKhuChungCu.Data_Access_Layer;
using QuanLyKhuChungCu.Entities;

namespace QuanLyKhuChungCu.Business
{
    public class DayCanHoBLL:IDayCanHoBLL
    {
        private IDayCanHoDAL dchDAL = new DayCanHoDAL();
        public List<DayCanHo> GetAllDayCanHo()
        {
            return dchDAL.GetAllDayCanHo();
        }
        public bool KiemTraMaDay(int maday)
        {
            bool ok = false;
            foreach (DayCanHo dch in dchDAL.GetAllDayCanHo())
            {
                if(dch.MaDay==maday)
                {
                    ok = true; break;
                }    
            }
            return ok;
        }
        public void Update(DayCanHo dch)
        {
            if (KiemTraMaDay(dch.MaDay))
                dchDAL.Update(dch);
            else throw new Exception("Khong ton tai ma day nay");
        }
        public void Insert(DayCanHo dch)
        {
            dchDAL.Insert(dch);
        }
        public void Delete(int maday)
        {
            dchDAL.Delete(maday);
        }
    }
}
