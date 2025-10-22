using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_6_BTTL
{
    internal class BietThu : BatDongSan,IHoTro
    {
        public BietThu(string ma, double cd, double cr) : base(ma, cd, cr) 
        { }

        public override double TinhGiaTri()
        {
            return TinhDienTich() * 400000 + PhiKinhDoanh();
        }
        public double PhiKinhDoanh()
        {
            return TinhDienTich() * 1000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write(" >> Phi kinh doanh : {0,-10}",PhiKinhDoanh());
        }
    }
}
