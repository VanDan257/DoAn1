using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Entities;

namespace QuanLyKhuChungCu.Data_Access_Layer.Service_Interface
{
    public interface IDayCanHoDAL
    {
        List<DayCanHo> GetAllDayCanHo();
        void Insert(DayCanHo dch);
        void Delete(int maday);
        void Update(DayCanHo dch);
        int GetMaDay();
    }
}
