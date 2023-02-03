using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class CHITIETCC
    {
        QuanLyNhanSuEntities2 et = new QuanLyNhanSuEntities2();

        public List<ChiTietChamCong> GetChiTietChamCongs()
        {
            return et.ChiTietChamCongs.ToList();
        }

        public ChiTietChamCong GetChiTietChamCong(string MA_CC,string MA_NV)
        {
            return et.ChiTietChamCongs.FirstOrDefault(x => x.MA_CC == MA_CC && x.MA_NV == MA_NV);
        }

        public IEnumerable<ChiTietChamCong> GetChiTietChamCongs2(string MA_CC)
        {
            IEnumerable<ChiTietChamCong> ls = et.ChiTietChamCongs.SqlQuery("select * from ChiTietChamCong where MA_CC = '"+MA_CC+"'").ToList();
            return ls;
        }
        
        public ChiTietChamCong Add(ChiTietChamCong cccc)
        {
            try
            {
                et.ChiTietChamCongs.Add(cccc);
                et.SaveChanges();
                return cccc;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
