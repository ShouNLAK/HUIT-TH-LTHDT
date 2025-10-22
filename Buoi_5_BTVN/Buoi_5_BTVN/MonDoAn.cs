using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTVN
{
    internal class MonDoAn : MonHoc
    {
        private double diemGVHD;
        private double diemGVPB;

        public double DiemGVHD
        {
            get { return diemGVHD; }
            set
            {
                if (value >= 0)
                    diemGVHD = value;
                else
                    throw new Exception("Diem phai lon hon 0");
            }
        }
        public double DiemGVPB
        {
            get { return diemGVPB; }
            set
            {
                if (value >= 0)
                    diemGVPB = value;
                else
                    throw new Exception("Diem phai lon hon 0");
            }
        }

        public MonDoAn(string ma, string ten , int sotc, string khoa, double diemHD, double diemPB)
            : base(ma,ten,sotc,khoa)
        {
            DiemGVHD = diemHD;
            DiemGVPB = diemPB;
        }

        public override double ChiPhiMonHoc()
        {
            return 2000000;
        }
        public override double DiemTongKet()
        {
            return (DiemGVHD*2 + DiemGVPB) / 3.0;
        }
        public override void Xuat()
        {
            base.XuatTT();
            Console.Write("Diem GVHD : {0,-5} | Diem GVPB : {1,-5} | TK: {2,-3} | {3,-10}",
                DiemGVHD,DiemGVPB,DiemTongKet(),ChiPhiMonHoc());
        }
    }
}
