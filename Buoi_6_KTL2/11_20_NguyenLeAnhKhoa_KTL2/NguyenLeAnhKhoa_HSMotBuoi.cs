using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_20_NguyenLeAnhKhoa_KTL2
{
    internal class NguyenLeAnhKhoa_HSMotBuoi : NguyenLeAnhKhoa_HocSinh
    {
        private int soBuoiHocKN;
        public int SoBuoiHocKN
        {
            get { return soBuoiHocKN; }
            set
            {
                if (value >= 0)
                    soBuoiHocKN = value;
                else
                    throw new Exception("Sai dinh dang");
            }
        }

        public NguyenLeAnhKhoa_HSMotBuoi() : base()
        { }
        public NguyenLeAnhKhoa_HSMotBuoi(string ma, string ht, int khoi, int sbn, int sbhkn)
            : base (ma,ht,khoi,sbn)
        {
            SoBuoiHocKN=sbhkn;
        }
        public double HP_HocKyNang()
        {
            return SoBuoiHocKN * 100000;
        }

        public override double TinhChiPhiKhac()
        {
            if (SoBuoiHocKN > 12 && SoBuoiNghi == 0)
                return HP_HocKyNang() * 0.93;
            return HP_HocKyNang();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write(" >> So buoi hoc ky nang : {0,-5} | Hoc phi hoc Ky nang : {1,-10}", SoBuoiHocKN,HP_HocKyNang());
        }
    }
}
