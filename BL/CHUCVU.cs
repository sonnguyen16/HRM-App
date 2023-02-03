using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class CHUCVU
    {
        QuanLyNhanSuEntities2 db = new QuanLyNhanSuEntities2();

        public ChucVu GetChucVu(string MA_CV)
        {
            return db.ChucVus.FirstOrDefault(x => x.MA_CV == MA_CV);
        }
        public List<ChucVu> GetChucVus()
        {
            return db.ChucVus.ToList();
        }
    }
}
