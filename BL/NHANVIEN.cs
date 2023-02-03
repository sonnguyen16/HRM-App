using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using DAL;

namespace BL
{
   
    public class NHANVIEN
    {
        QuanLyNhanSuEntities2 db = new QuanLyNhanSuEntities2();
       
        public NhanVien GetNhanVien(string MA_NV)
        {
            return db.NhanViens.FirstOrDefault(x => x.MA_NV == MA_NV);
        }
        public List<NhanVien> GetNhanViens()
        {
            return db.NhanViens.ToList();
        }

        public NhanVien Add(NhanVien nv)
        {
            try
            {
                db.NhanViens.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public NhanVien Update(NhanVien nv)
        {
            try
            {
               var _nv = db.NhanViens.FirstOrDefault(x => x.MA_NV == nv.MA_NV);
                _nv.Hinh_Anh = nv.Hinh_Anh;
                _nv.Ho_Ten = nv.Ho_Ten;
                _nv.Gioi_Tinh = nv.Gioi_Tinh;
                _nv.Ngay_Sinh = nv.Ngay_Sinh;
                _nv.Dia_Chi = nv.Dia_Chi;
                _nv.Dan_Toc = nv.Dan_Toc;
                _nv.So_CCCD = nv.So_CCCD;
                _nv.So_Dt = nv.So_Dt;
                _nv.Email = nv.Email;
                _nv.Hon_Nhan = nv.Hon_Nhan;
                _nv.MA_CV = nv.MA_CV;
                _nv.MA_PB = nv.MA_PB;
                db.SaveChanges();
               return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public void Delete(string MA_NV)
        {
            try
            {
                var _nv = db.NhanViens.FirstOrDefault(x => x.MA_NV == MA_NV);
                db.NhanViens.Remove(_nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public IEnumerable<NhanVien> Search(string condi, string key)
        {
            IEnumerable<NhanVien> ls = db.NhanViens.SqlQuery("select * from NhanVien where "+condi+" like '%"+key+"%'").ToList();

            return ls;
        }

    }
}
