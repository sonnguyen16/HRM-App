using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class BANGLUONG
    {
        QuanLyNhanSuEntities2 et = new QuanLyNhanSuEntities2();
        public List<BangLuong> GetBangLuongs()
        {
            return et.BangLuongs.ToList();
        }

        public BangLuong GetBangLuong(string MA_LUONG)
        {
            return et.BangLuongs.FirstOrDefault(x => x.MA_LUONG == MA_LUONG);
        }

        public BangLuong Add(BangLuong bl)
        {
            try
            {
                et.BangLuongs.Add(bl);
                et.SaveChanges();
                return bl;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BangLuong Update(BangLuong bl)
        {
            try
            {
                var _bl = et.BangLuongs.FirstOrDefault(x => x.MA_NV == bl.MA_NV && x.MA_CC == bl.MA_CC);
                _bl.Thuc_Lanh = bl.Thuc_Lanh;
                et.SaveChanges();
                return bl;
            }
            catch (Exception)
            {

                throw;
            }
        }

      

    }
}
