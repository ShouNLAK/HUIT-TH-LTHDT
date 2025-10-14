using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTVN
{
    internal class MonThucHanh : MonHoc
    {
        private double diemLan1;
        private double diemLan2;
        private double diemLan3;
        private double diemLan4;

        public double DiemLan1
        {
            get { return diemLan1; }
            set
            {
                if (value >= 0)
                    diemLan1 = value;
                else
                    throw new Exception("Diem phai lon hon 0");
            }
        }
        public double DiemLan2
        {
            get { return diemLan2; }
            set
            {
                if (value >= 0)
                    diemLan2 = value;
                else
                    throw new Exception("Diem phai lon hon 0");
            }
        }
        public double DiemLan3
        {
            get { return diemLan3; }
            set
            {
                if (value >= 0)
                    diemLan3 = value;
                else
                    throw new Exception("Diem phai lon hon 0");
            }
        }
        public double DiemLan4
        {
            get { return diemLan4; }
            set
            {
                if (value >= 0)
                    diemLan4 = value;
                else
                    throw new Exception("Diem phai lon hon 0");
            }
        }

        public MonThucHanh(string ma, string ten, int sotc, string khoa, double d1, double d2, double d3, double d4)
            : base(ma,ten,sotc,khoa)
        {
            DiemLan1 = d1;
            DiemLan2 = d2;
            DiemLan3 = d3;
            DiemLan4 = d4;
        }

        public override double ChiPhiMonHoc()
        {
            return 350000 * SoTC + 100000;
        }

        public override double DiemTongKet()
        {
            return (DiemLan1 + DiemLan2 + DiemLan3 + DiemLan4) / 4.0;
        }
        public override void Xuat()
        {
            base.XuatTT();
            Console.Write("L1: {0,-3} | L2: {1,-3} | L3: {2,-3} | L4: {3,-3} | TK: {4,-3} | {5,-10}",
                DiemLan1, DiemLan2, DiemLan3, DiemLan4, DiemTongKet(), ChiPhiMonHoc());
        }
    }
}
