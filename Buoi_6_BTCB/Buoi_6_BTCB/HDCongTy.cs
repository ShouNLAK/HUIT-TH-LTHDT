using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_6_BTCB
{
    internal class HDCongTy : HoaDon,IHoTro
    {
        private int soLuongNV;
        public int SoLuongNV
        {
            get { return soLuongNV; }
            set { soLuongNV = value; }
        }

        public HDCongTy()
        {
            SoLuongNV = 5;
        }
        public HDCongTy(string ma, string ten, double sl, double gia, int nv) : base(ma,ten,sl,gia)
        {
            SoLuongNV = nv;
        }
        public override double TinhChietKhau()
        {
            if (SoLuongNV > 500)
                return 0.05 * SoLuong * GiaBan;
            else if (SoLuongNV > 100)
                return 0.03 * soLuongNV * GiaBan;
            return 0;
        }
        public double HoTroGia()
        {
            return 12000*SoLuongNV;
        }
        public override double TinhThanhTien()
        {
            return base.TinhThanhTien() - HoTroGia();
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so luong nhan vien : ");
            SoLuongNV = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("==============================");
            base.XuatTT();
            Console.WriteLine("So luong Nhan Vien : {0,-20}", SoLuongNV);
            Console.WriteLine("==============================");
        }
    }
}
