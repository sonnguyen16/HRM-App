using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public string Ten_Tk { get; set; }
        public string Mat_Khau { get; set; }
        public int Loai_Tk { get; set; }
        public string MA_NV { get; set; }

        public TaiKhoan(string Ten_Tk,string Mat_Khau,int Loai_Tk,string MA_NV)
        {
            this.Ten_Tk = Ten_Tk;
            this.Mat_Khau = Mat_Khau;
            this.Loai_Tk = Loai_Tk;
            this.MA_NV = MA_NV;
        }
    }
}
