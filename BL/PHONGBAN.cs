using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
     public class PHONGBAN
    {
        QuanLyNhanSuEntities2 db = new QuanLyNhanSuEntities2();

        public PhongBan GetPhongBan(string MA_PB)
        {
            return db.PhongBans.FirstOrDefault(x => x.MA_PB == MA_PB);
        }
        public List<PhongBan> GetPhongBans()
        {
            return db.PhongBans.ToList();
        }
    }
}
