using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Entities;

namespace QuanLyKhuChungCu.Data_Access_Layer.Service_Interface
{
    public interface IHoaDonDAL
    {
        List<HoaDon> GetAllHoaDon();
        int GetMaHD();
        void Insert(HoaDon hd);
        void Delete(int mahd);
        void Update(HoaDon hd);
    }
}
