using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class BANGCHAMCONG
    {
        QuanLyNhanSuEntities2 et = new QuanLyNhanSuEntities2();
        public List<BangChamCong> GetBangChamCongs()
        {
            return et.BangChamCongs.ToList();
        }

        public BangChamCong GetBangChamCong(string MA_CC)
        {
            return et.BangChamCongs.FirstOrDefault(x => x.MA_CC == MA_CC);
        }

        public BangChamCong Add(BangChamCong bcc)
        {
            try
            {
                et.BangChamCongs.Add(bcc);
                et.SaveChanges();
                return bcc;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BangChamCong Update(BangChamCong bcc)
        {
            try
            {
                var _bcc = et.BangChamCongs.FirstOrDefault(x => x.MA_CC == bcc.MA_CC);
                _bcc.MA_CC = bcc.MA_CC;
                _bcc.Thang = bcc.Thang;
                _bcc.Nam = bcc.Nam;
                _bcc.Tinh_Trang = bcc.Tinh_Trang;
                et.SaveChanges();
                return bcc;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<BangChamCong> getBL()
        {
            List<BangChamCong> ls = et.BangChamCongs.SqlQuery("select * from BangChamCong where Tinh_Trang = 'true' and MA_CC not in (select MA_CC from BangLuong)").ToList();
            return ls;
        }

        public IEnumerable<BangChamCong> getBL2()
        {
            List<BangChamCong> ls = et.BangChamCongs.SqlQuery("select * from BangChamCong where MA_CC  in (select MA_CC from BangLuong)").ToList();
            return ls;
        }

        public IEnumerable<BangChamCong> getBL3()
        {
            List<BangChamCong> ls = et.BangChamCongs.SqlQuery("select * from BangChamCong where MA_CC in (select MA_CC from BangLuong) and Thang = 2").ToList();
            return ls;
        }
    }
}
