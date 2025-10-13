using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi_5_BTCB
{
    public class NhanVienKD : NhanVienABC
    {
        private double dsThucTe;
        private double dsToiThieu;
        public double phanTramHH
        {
            get 
            {
                return DSThucTe >= DSToiThieu * 1.15 ? 0.15 : 0;
            }
        }

        public double DSThucTe
        {
            get { return dsThucTe; }
            set { dsThucTe = value; }
        }
        public double DSToiThieu
        {
            get { return dsToiThieu; }
            set { dsToiThieu = value; }
        }

        public NhanVienKD(string ma, string ten, int ns, int nvl, string phai, double hsl, double dstt, double minds) : 
            base(ma, ten, ns, nvl, phai, hsl)
        {
            DSToiThieu = minds;
            DSThucTe = dstt;
        }

        public override double TinhLuong()
        {
            return heSoLuong * LuongCoBan * (1 + phanTramHH);
        }

        public override char XepLoai()
        {
            if (dsThucTe >= dsToiThieu)
            {
                if (dsThucTe >= dsToiThieu * 2.0)
                    return 'A';
                else
                    return 'B';
            }
            else
            {
                if (dsThucTe <= dsToiThieu * 0.5)
                    return 'D';
                else
                    return 'C';
            }
        }

        public void Xuat()
        {
            Console.WriteLine("{0,-8} | {1,-20} | {2,-5} | {3,-5} | {4,-5} | {5,-7} | T.Te / T.Thieu : {6,-5}/{7,-5} | {8,-2} | {9,-10}",
                maNhanVien, tenNhanVien, namSinh, namVaoLam, gioiTinh, heSoLuong, DSThucTe,DSToiThieu, XepLoai(), TinhThuNhap());
        }
    }
}