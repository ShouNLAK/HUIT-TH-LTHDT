using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_20_NguyenLeAnhKhoa_KTL2
{
    internal class NguyenLeAnhKhoa_HSBanTru : NguyenLeAnhKhoa_HocSinh,NguyenLeAnhKhoa_IChiPhi
    {
        private string dangKy_TABN;
        public static double tienAnMotNgay = 27500;
        public string DangKy_TABN
        {
            get { return dangKy_TABN;}
            set
            {
                if (value == "1" || value == "0")
                    dangKy_TABN = value;
                else
                    throw new Exception("CHi nhan gia tri 0 - Khong | 1 - Co");
            }
        }

        public NguyenLeAnhKhoa_HSBanTru() : base()
        {

        }
        public NguyenLeAnhKhoa_HSBanTru(string ma, string ht, int khoi, int sbn, string dk_TiengAnhBanNgu)
            : base(ma, ht, khoi, sbn)
        {
            DangKy_TABN = dk_TiengAnhBanNgu;
        }

        public double TienAn()
        {
            return (22 - SoBuoiNghi / 2) * tienAnMotNgay;
        }
        public double HP_TiengAnhBanNgu()
        {
            return (KhoiLop == 6 ? 200000 : (KhoiLop == 7 ? 220000 : (KhoiLop == 8 ? 240000 : 260000)));
        }
        public override double TinhChiPhiKhac()
        {
            return TienAn() + HP_TiengAnhBanNgu() + TinhChiPhi_CSVC();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write(" >> Tien an : {0,-10} | Hoc phi TABN : {1,-10} | Chi phi CSVC : {2,-10}", TienAn(), HP_TiengAnhBanNgu(),TinhChiPhi_CSVC());
        }
        public double TinhChiPhi_CSVC()
        {
            return 200000;
        }
    }
}
