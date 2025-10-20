using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTTL
{
    internal class HDCongTy : HoaDon
    {
        private int soLuongNV;
        public int SoLuongNV
        {
            get { return soLuongNV; }
            set { soLuongNV = value; }
        }

        public HDCongTy()
        { 
        }
        public HDCongTy(string ma, string ten, double sl, double gia, int nv) : base(ma,ten,sl,gia)
        {
            SoLuongNV = nv;
        }
        public override double TinhChietKhau()
        {
            if (SoLuongNV > 5000)
                return 0.05 * SoLuong * GiaBan;
            else if (SoLuongNV > 1000)
                return 0.03 * soLuongNV * GiaBan;
            return 0;
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
