using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_6_BTTL
{
    internal class DatTrong : BatDongSan
    {
        public DatTrong(string ma, double cd,double cr) : base(ma, cd, cr) 
        { }

        public override double TinhGiaTri()
        {
            return TinhDienTich() * 10000;
        }
    }
}
