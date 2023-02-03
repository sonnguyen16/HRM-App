using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class TAIKHOAN
    {
        QuanLyNhanSuEntities2 et = new QuanLyNhanSuEntities2();
        public List<TaiKhoan> GetTaiKhoans()
        {
            return et.TaiKhoans.ToList();
        }
        public TaiKhoan GetTaiKhoan(string Ten_Tk)
        {
            return et.TaiKhoans.FirstOrDefault(x=>x.Ten_TK == Ten_Tk);
        }

        public TaiKhoan Update(TaiKhoan tk)
        {
            try
            {
                var _tk = et.TaiKhoans.FirstOrDefault(x => x.Ten_TK == tk.Ten_TK);
                _tk.Mat_Khau = tk.Mat_Khau;
                et.SaveChanges();
                return tk;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
