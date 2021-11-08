using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Business.Service_Interface;
using QuanLyKhuChungCu.Data_Access_Layer.Service_Interface;
using QuanLyKhuChungCu.Data_Access_Layer;
using QuanLyKhuChungCu.Entities;

namespace QuanLyKhuChungCu.Business
{
    public class HoaDonBLL:IHoaDonBLL
    {
        private IHoaDonDAL hdDAL = new HoaDonDAL();
        public List<HoaDon> GetAllHoaDon()
        {
            return hdDAL.GetAllHoaDon();
        }
        public bool KiemTraHoaDon(int mahd)
        {
            bool ok = false;
            foreach (HoaDon hd in hdDAL.GetAllHoaDon())
            {
                if (hd.MaHD == mahd)
                {
                    ok = true;
                    break;
                }
            }
            return ok;
        }
        public void Insert(HoaDon hd)
        {
            hdDAL.Insert(hd);
        }
        public void Delete(int mahd)
        {
            hdDAL.Delete(mahd);
        }
        public void Update(HoaDon ch)
        {
            if (KiemTraHoaDon(ch.MaHD))
                hdDAL.Update(ch);
            else
                throw new Exception("Khong ton tai hoa don nay");
        }
    }
}
