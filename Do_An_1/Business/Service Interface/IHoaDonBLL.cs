using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Entities;
using QuanLyKhuChungCu.Data_Access_Layer.Service_Interface;

namespace QuanLyKhuChungCu.Business.Service_Interface
{
    public interface IHoaDonBLL
    {
        List<HoaDon> GetAllHoaDon();
        void Insert(HoaDon hd);
        void Delete(int mahd);
        void Update(HoaDon hd);
    }
}
