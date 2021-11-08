using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using QuanLyKhuChungCu.Entities;

namespace QuanLyKhuChungCu.Data_Access_Layer.Service_Interface
{
    public interface ICanHoDAL
    {
        List<CanHo> GetAllCanHo();
        void Insert(CanHo ch);
        void Delete(int sonha);
        int GetSoNha();
        void Update(CanHo ch);
    }
}
