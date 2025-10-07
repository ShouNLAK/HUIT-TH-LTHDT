using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_BTTL
{
    internal class Nguoi
    {
        protected string hoTen;
        protected string ngaySinh;
        protected string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set {
                if (value == "Nam" || value == "Nu")
                    gioiTinh = value;
                else
                    gioiTinh = "Nam";
                }
        }
        public Nguoi()
        {
            GioiTinh = "Nam";
        }
        public Nguoi(string ht, string ns, string gt)
        {
            hoTen = ht;
            ngaySinh = ns;
            GioiTinh = gt;
        }
        public virtual void Xuat()
        {
            Console.Write("{0,-20} | {1,-10} | {2,-5} | ",hoTen,ngaySinh,GioiTinh);
        }
    }
}
