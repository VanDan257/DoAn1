using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Business.Service_Interface;
using QuanLyKhuChungCu.Data_Access_Layer.Service_Interface;
using QuanLyKhuChungCu.Data_Access_Layer;
using QuanLyKhuChungCu.Entities;

namespace QuanLyKhuChungCu.Business
{
    public class CanHoBLL:ICanHoBLL
    {
        private ICanHoDAL chDAL = new CanHoDAL();
        public List<CanHo> GetAllCanHo()
        {
            return chDAL.GetAllCanHo();
        }
        public bool KiemTraCanHo(int sonha)
        {
            bool ok = false;
            foreach (CanHo ch in chDAL.GetAllCanHo())
            {
                if(ch.SoNha==sonha)
                {
                    ok = true;
                    break;
                }    
            }
            return ok;
        }
        public void Update(CanHo ch)
        {
            if (KiemTraCanHo(ch.SoNha))
                chDAL.Update(ch);
            else
                throw new Exception("Khong ton tai so nha nay");
        }
        public void Insert(CanHo ch)
        {
            chDAL.Insert(ch);
        }
        public void Delete(int sonha)
        {
            chDAL.Delete(sonha);
        }
    }
}
