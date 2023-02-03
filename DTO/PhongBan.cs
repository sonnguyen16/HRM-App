using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBan
    {
        string Ma_PhongBan;
        string Ten_PhongBan;
        string Ghi_Chu;

        public PhongBan()
        {
            Ma_PhongBan = "";
            Ten_PhongBan = "";
            Ghi_Chu = "";
        }

        public string getMa_PhongBan() { return Ma_PhongBan; }
        public string getTen_PhongBan() { return Ten_PhongBan; }
        public string getGhi_Chu() { return Ghi_Chu; }

        public void setMa_PhongBan(string s) { Ma_PhongBan = s; }
        public void setTen_PhongBan(string s) {  Ten_PhongBan = s; }
        public void setGhi_Chu(string s) {  Ghi_Chu = s; }

    }
}
