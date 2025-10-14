using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTVN
{
    internal class MonLyThuyet : MonHoc
    {
        private double diemTL;
        private double diemGK;
        private double diemCK;

        public double DiemTL
        {
            get { return diemTL; }
            set 
            {
                if (value >= 0)
                    diemTL = value;
                else
                    throw new Exception("Diem phai lon hon 0");
            }
        }
        public double DiemGK
        {
            get { return diemGK; }
            set
            {
                if (value >= 0)
                    diemGK = value;
                else
                    throw new Exception("Diem phai lon hon 0");
            }
        }
        public double DiemCK
        {
            get { return diemCK; }
            set
            {
                if (value >= 0)
                    diemCK = value;
                else
                    throw new Exception("Diem phai lon hon 0");
            }
        }

        public MonLyThuyet(string ma, string ten, int sotc, string khoa, double tl, double gk, double ck)
            :base(ma,ten,sotc,khoa)
        {
            DiemTL = tl; 
            DiemGK = gk; 
            DiemCK = ck;
        }

        public override double DiemTongKet()
        {
            return DiemTL*0.2 + DiemGK*0.3 + DiemCK*0.5;
        }
        public override double ChiPhiMonHoc()
        {
            return 250000 * SoTC;
        }
        public override void Xuat()
        {
            base.XuatTT();
            Console.Write("TL: {0,-6} | GK: {1,-6} | CK: {2,-7} | TK: {3,-3} | {4,-10}",
                DiemTL, DiemGK, DiemCK, DiemTongKet(), ChiPhiMonHoc());
        }
    }
}
