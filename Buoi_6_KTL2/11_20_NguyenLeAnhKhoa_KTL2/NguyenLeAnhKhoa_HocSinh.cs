using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_20_NguyenLeAnhKhoa_KTL2
{
    abstract class NguyenLeAnhKhoa_HocSinh
    {
        protected string maHS;
        protected string hoTenHS;
        protected int khoiLop;
        protected int soBuoiNghi;

        public string MaHS
        {
            get { return maHS; } 
            set { maHS = value; }
        }
        public string HoTenHS
        {
            get { return hoTenHS; }
            set { hoTenHS = value; }
        }
        public int KhoiLop
        {
            get { return khoiLop; }
            set 
            {
                if (value <= 9 && value >= 6)
                    khoiLop = value;
                else
                    throw new Exception("Khoi lop phai tu 6 -> 9");
            }
        }
        public int SoBuoiNghi
        {
            get { return soBuoiNghi; }
            set 
            {
                if (value >= 0)
                    soBuoiNghi = value;
                else
                    throw new Exception("So buoi nghi phai lon hon 0");
            }
        }

        public NguyenLeAnhKhoa_HocSinh()
        {

        }
        public NguyenLeAnhKhoa_HocSinh(string ma, string ht, int lop, int sobuoi)
        {
            MaHS = ma;
            HoTenHS = ht;
            KhoiLop = lop;
            soBuoiNghi = sobuoi;
        }

        public double HocPhi()
        {
            return (KhoiLop == 6 ? 870000 : (KhoiLop == 7 ? 890000 : (KhoiLop == 8 ? 920000 : 950000)));
        }
        public double TongTien()
        {
            return HocPhi() + TinhChiPhiKhac();
        }
        public abstract double TinhChiPhiKhac();
        public virtual void Xuat()
        {
            Console.Write("{0,-10} | {1,-20} | {2,-5} | {3,-12} | {4,-15} | {5,-15} | {6,-15}",
                MaHS,HoTenHS,KhoiLop, SoBuoiNghi,HocPhi(),TinhChiPhiKhac(),TongTien());
        }

    }
}
