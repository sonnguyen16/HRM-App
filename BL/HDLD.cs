using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class HDLD
    {
        QuanLyNhanSuEntities2 et = new QuanLyNhanSuEntities2();

        public List<HopDongLaoDong> GetHopDongLaoDongs()
        {
            return et.HopDongLaoDongs.ToList();
        }

        public HopDongLaoDong GetHopDongLaoDong(string MA_HD)
        {
            return et.HopDongLaoDongs.FirstOrDefault(x => x.MA_HD == MA_HD);
        }

        public HopDongLaoDong Add(HopDongLaoDong hdld)
        {
            try
            {
                et.HopDongLaoDongs.Add(hdld);
                et.SaveChanges();
                return hdld;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public HopDongLaoDong Update(HopDongLaoDong hdld)
        {
            try
            {
                var _hdld = et.HopDongLaoDongs.FirstOrDefault(x => x.MA_HD == hdld.MA_HD);
                _hdld.MA_NV = hdld.MA_NV;
                _hdld.LOAI_HD = hdld.LOAI_HD;
                _hdld.LAN_KY = hdld.LAN_KY;
                _hdld.NGAY_BD = hdld.NGAY_BD;
                _hdld.NGAY_KT = hdld.NGAY_KT;
                _hdld.NOI_DUNG = hdld.NOI_DUNG;
                _hdld.NGAY_KY = hdld.NGAY_KY;
                et.SaveChanges();
                return hdld;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(string MA_HD)
        {
            try
            {
                var _hdld = et.HopDongLaoDongs.FirstOrDefault(x => x.MA_HD  == MA_HD);
                et.HopDongLaoDongs.Remove(_hdld);
                et.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public IEnumerable<HopDongLaoDong> Search(string condi, string key)
        {
            IEnumerable<HopDongLaoDong> ls = et.HopDongLaoDongs.SqlQuery("select * from HopDongLaoDong where " + condi + " like '%" + key + "%'").ToList();

            return ls;
        }

        public IEnumerable<NhanVien> GetNhanViens()
        {
            IEnumerable<NhanVien> ls = et.NhanViens.SqlQuery("select * from NhanVien where MA_NV not in (select MA_NV from HopDongLaoDong)").ToList();
            return ls;
        }
    }
}
