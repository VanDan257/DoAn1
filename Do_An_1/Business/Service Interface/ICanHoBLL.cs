using System;
using System.Collections.Generic;
using System.Text;
using QuanLyKhuChungCu.Entities;
using QuanLyKhuChungCu.Data_Access_Layer.Service_Interface;

namespace QuanLyKhuChungCu.Business.Service_Interface
{
    public interface ICanHoBLL
    {
        List<CanHo> GetAllCanHo();
        void Insert(CanHo ch);
        void Delete(int sonha);
        void Update(CanHo ch);
    }
}
