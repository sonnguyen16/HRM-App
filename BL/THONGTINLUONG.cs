using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class THONGTINLUONG
    {
        QuanLyNhanSuEntities2 et = new QuanLyNhanSuEntities2();

        public List<ThongTinLuong> GetThongTinLuongs()
        {
            return et.ThongTinLuongs.ToList();
        }
    }
}
