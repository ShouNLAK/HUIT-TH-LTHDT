using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTVN
{
    abstract class MonHoc
    {
        protected string maMon;
        protected string tenMon;
        protected int soTC;
        protected string khoaPhuTrach;
        
        public string MaMon
        {
            get { return maMon; }
            set { maMon = value; }
        }
        public string TenMon
        { 
            get { return tenMon; } 
            set { tenMon = value; } 
        }
        public int SoTC
        {
            get { return soTC; }
            set { soTC = value; }
        }
        public string KhoaPhuTrach
        {
            get { return khoaPhuTrach; }
            set { khoaPhuTrach = value; }
        }

        public MonHoc()
        { }
        public MonHoc(string ma, string ten, int sotc, string khoa)
        {
            MaMon = ma;
            TenMon = ten;
            SoTC = sotc;
            khoaPhuTrach = khoa;
        }
        public void XuatTT()
        {
            Console.Write("{0,-10} | {1,-20} | {2,-5} | {3,-20} | ", MaMon, TenMon, SoTC, KhoaPhuTrach);
        }

        public abstract double DiemTongKet();
        public abstract double ChiPhiMonHoc();
        public abstract void Xuat();
    }
}
