using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu
    {
        string Ma_ChucVu;
        string Ten_ChucVu;
        string Ghi_Chu;

        public string getMa_ChucVu() { return Ma_ChucVu; }
        public string getTen_ChucVu() { return Ten_ChucVu; }
        public string getGhi_Chu() { return Ghi_Chu; }

        public void setMa_ChucVu(string s) { Ma_ChucVu = s; }
        public void setTen_ChucVu(string s) {  Ten_ChucVu = s; }
        public void setGhi_Chu(string s) {  Ghi_Chu = s; }

    }
}
