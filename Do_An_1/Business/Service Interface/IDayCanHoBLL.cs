using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Entities;
using QuanLyKhuChungCu.Data_Access_Layer.Service_Interface;

namespace QuanLyKhuChungCu.Business.Service_Interface
{
    public interface IDayCanHoBLL
    {
        List<DayCanHo> GetAllDayCanHo();
        void Insert(DayCanHo dch);
        void Delete(int maday);
        void Update(DayCanHo dch);
    }
}
