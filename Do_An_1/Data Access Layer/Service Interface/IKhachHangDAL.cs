using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Entities;

namespace QuanLyKhuChungCu.Data_Access_Layer.Service_Interface
{
    public interface IKhachHangDAL
    {
        List<KhachHang> GetAllKhachHang();
        void Insert(KhachHang kh);
        void Delete(int makh);
        void Update(KhachHang kh);
        int GetMaKH();
    }
}
