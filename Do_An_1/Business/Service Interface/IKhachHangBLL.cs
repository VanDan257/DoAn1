using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Entities;

namespace QuanLyKhuChungCu.Business.Service_Interface
{
    public interface IKhachHangBLL
    {
        List<KhachHang> GetAllKhachHang();
        void Insert(KhachHang kh);
        void Delete(int makh);
        void Update(KhachHang kh);
    }
}
