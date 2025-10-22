using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_6_BTTL
{
    internal class KhachSan : BatDongSan,IHoTro
    {
        private double soSao;
        public double SoSao
        {
            get { return soSao; }
            set
            {
                if (value > 0)
                    soSao = value;
                else
                    throw new Exception("Sai dinh dang");
            }
        }
        public KhachSan(string ma, double cd, double cr, double sao) : base (ma,cd,cr)
        {
            SoSao = sao;
        }
        public override double TinhGiaTri()
        {
            return 100000 + 50000 * SoSao + PhiKinhDoanh();
        }
        public double PhiKinhDoanh()
        {
            return ChieuRong * 5000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write(" >> So sao : {0,-10} | Phi Kinh Doanh : {1,-10}", SoSao,PhiKinhDoanh());
        }
    }
}
