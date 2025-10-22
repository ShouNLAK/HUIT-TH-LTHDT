using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_BTTL
{
    internal class SinhVien : Nguoi
    {
        private string maSoSV;
        private string heDT;

        public string HeDT
        {
            get { return heDT; }
            set
            {
                if (value == "Cao dang" || value == "Cao dang nghe")
                    heDT = value;
                else
                    heDT = "Dai hoc";
            }
        }
        public int TongTC
        {
            get 
            {
                if (HeDT == "Dai hoc") return 150;
                else if (HeDT == "Cao dang") return 100;
                else return 130;
            }
        }
        public int HPTC
        {
            get
            {
                if (HeDT == "Dai hoc") return 200000;
                else if (HeDT == "Cao dang") return 150000;
                else return 120000;
            }
        }
        public double TongHP()
        {
            return TongTC * HPTC;
        }

        public SinhVien(string ht, string ns, string gt, string mssv, string hdt) : base (ht,ns,gt)
        {
            maSoSV = mssv;
            HeDT = hdt;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("{0,-8} | {1,-15} | {2,-8} | {3,-10} | {4,-10}",maSoSV,HeDT,TongTC,HPTC,TongHP());
        }
    }
}
