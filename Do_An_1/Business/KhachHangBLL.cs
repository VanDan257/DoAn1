using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Business.Service_Interface;
using QuanLyKhuChungCu.Data_Access_Layer.Service_Interface;
using QuanLyKhuChungCu.Data_Access_Layer;
using QuanLyKhuChungCu.Entities;

namespace QuanLyKhuChungCu.Business
{
    public class KhachHangBLL:IKhachHangBLL
    {
        private IKhachHangDAL khDAL = new KhachHangDAL();
        private ICanHoDAL chDAL = new CanHoDAL();
        public List<KhachHang> GetAllKhachHang()
        {
            return khDAL.GetAllKhachHang();
        }
        public bool KiemTraMaKH(int makh)
        {
            bool ok = true;
            foreach (KhachHang kh in khDAL.GetAllKhachHang())
            {
                if (kh.MaKH == makh)
                {
                    ok = true;
                    break;
                }
            }
            return ok;
        }
        public void Insert(KhachHang kh)
        {
            if (kh.HoTen != "" && kh.DiaChi != "")
                khDAL.Insert(kh);
            else throw new Exception("Du lieu sai!");
        }
        public void Delete(int makh)
        {
            if (KiemTraMaKH(makh))
                khDAL.Delete(makh);
            else throw new Exception("Khong ton tai khach hang co ma nay!");
        }
        public void Update(KhachHang kh)
        {
            if (KiemTraMaKH(kh.MaKH))
                khDAL.Update(kh);
            else throw new Exception("Ma khach hang khong ton tai");
        }
    }
}
