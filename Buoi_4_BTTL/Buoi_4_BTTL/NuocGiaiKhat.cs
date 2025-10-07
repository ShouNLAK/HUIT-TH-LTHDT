using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_BTTL
{
    internal class NuocGiaiKhat:HangHoa
    {
        private string dvTinh;
        private int soLuong;
        private double donGia;

        public static double tyLeCK = 0.05;
        public string DvTinh
        {
            get { return dvTinh; }
            set
            {
                if (value == "Thung" || value == "Chai" || value == "Lon")
                    dvTinh = value;
                else
                    dvTinh = "Ket";
            }
        }

        public NuocGiaiKhat(string ma, string ten, string dvt, int sl, double dg) : base(ma,ten)
        {
            DvTinh = dvt;
            soLuong = sl;
            donGia = dg;
        }

        public double TinhThanhTien()
        {
            if (DvTinh == "Ket" || DvTinh == "Thung")
                return soLuong * donGia;
            else if (DvTinh == "Chai")
                return soLuong * donGia / 20;
            return soLuong * donGia / 24;
        }

        public double TinhTongTien()
        {
            return TinhThanhTien() * tyLeCK;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write(" {0,-8} | {1,-8} | {2,-10} | {3,-10}",DvTinh,soLuong,donGia,TinhTongTien());
        }
    }
}
