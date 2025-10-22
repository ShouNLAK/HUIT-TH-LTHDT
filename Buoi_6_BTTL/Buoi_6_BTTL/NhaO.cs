using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_6_BTTL
{
    internal class NhaO : BatDongSan
    {
        private int soLau;
        public int SoLau
        {
            get { return soLau; } 
            set {
                if (value > 0)
                    soLau = value;
                else
                    throw new Exception("Sai dinh dang");
            }
        }
        public NhaO (string ma, double cd, double cr, int solau) : base (ma,cd,cr)
        {
            SoLau = solau;
        }

        public override double TinhGiaTri()
        {
            return TinhDienTich() * 10000 + SoLau * 100000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write(" >> So lau : {0,-10}",SoLau);
        }
    }
}
