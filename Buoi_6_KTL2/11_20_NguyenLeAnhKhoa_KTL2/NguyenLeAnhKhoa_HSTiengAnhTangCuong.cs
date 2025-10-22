using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_20_NguyenLeAnhKhoa_KTL2
{
    internal class NguyenLeAnhKhoa_HSTiengAnhTangCuong : NguyenLeAnhKhoa_HocSinh,NguyenLeAnhKhoa_IChiPhi
    {
        public NguyenLeAnhKhoa_HSTiengAnhTangCuong() : base()
        {

        }
        public NguyenLeAnhKhoa_HSTiengAnhTangCuong(string ma, string ht, int khoi, int sbn)
            : base(ma, ht, khoi, sbn)
        {

        }
        public double HP_ToanTiengAnh()
        {
            return (KhoiLop == 6 || KhoiLop == 7) ? 3000000 : 3500000;
        }

        public override double TinhChiPhiKhac()
        {
            return 300000 + HP_ToanTiengAnh() + TinhChiPhi_CSVC();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write(" >> Hoc phi Toan Tieng Anh: {0,-10} | Chi phi CSVC : {1,-10}", HP_ToanTiengAnh(),TinhChiPhi_CSVC());
        }
        public double TinhChiPhi_CSVC()
        {
            return 450000 + (KhoiLop == 6 ? 0 : (KhoiLop == 9 ? 120000 : 100000));
        }
    }
}
