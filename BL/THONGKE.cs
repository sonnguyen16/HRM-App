using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
     public class THONGKE
    {
        QuanLyNhanSuEntities2 et = new QuanLyNhanSuEntities2();

         public List<Thongkes> GetThongkes()
        {
            
            List<Thongkes> ls = new List<Thongkes>();
            var _tk = et.THONG_KE_NV_PB2().ToList();

            foreach (var item in _tk)
            {
                Thongkes tk = new Thongkes();
                tk.ID = item.MA_PB;
                tk.Name = item.TEN_PB;
                tk.Count = (int)item.TONG_NV;

                ls.Add(tk);
            }
           
            return ls;
        }

        public List<Thongkes> GetThongkes2()
        {
            List<Thongkes> ls = new List<Thongkes>();
            var _tk = et.THONG_KE_NV_CV().ToList();

            foreach (var item in _tk)
            {
                Thongkes tk = new Thongkes();
                tk.ID = item.MA_CV;
                tk.Name = item.TEN_CV;
                tk.Count = (int)item.TONG_NV;

                ls.Add(tk);
            }

            return ls;
        }

        public List<Thongkes> GetThongkesLuong(int ThangS,int ThangE,int NamS)
        {
            List<Thongkes> ls = new List<Thongkes>();
            var _tk = et.Thong_Ke_Luong4(ThangS,ThangE,NamS).ToList();

            foreach (var item in _tk)
            {
                Thongkes tk = new Thongkes();
                tk.ID = item.Thang.ToString();
                tk.Name = item.Nam.ToString();
                tk.Count = (int)item.total;

                ls.Add(tk);
            }

            return ls;
        }
    }
}
