using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2
{
    public class PhanSo
    {
        public int tuSo;
        public int mauSo;

        public int TuSo
        {
            get { return tuSo; }
            set
            {
                tuSo = value;
            }
        }
        public int MauSo
        {
            get { return mauSo; }
            set
            {
                if (value != 0)
                    mauSo = value;
                else
                    throw new Exception("Mau so phai lon hon 0");
            }
        }
        public PhanSo()
        {
            TuSo= 0;
            MauSo = 1;
        }
        public PhanSo(int tuSo,int mauSo)
        {
            TuSo = tuSo;
            MauSo= mauSo;
        }
        public PhanSo(PhanSo obj)
        {
            TuSo = obj.tuSo;
            MauSo= obj.mauSo;
        }
        public void xuat()
        {
            toiGianPS();
            Console.Write("{0}/{1}  ",TuSo,MauSo);
        }
        public void nhap()
        {
            Console.Write("Nhap tu so : ");
            TuSo = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap mau so : ");
            MauSo = int.Parse(Console.ReadLine());
        }
        public void toiGianPS()
        {
            int UCLN = TienIch.tinhUCLN(TuSo,MauSo);
            TuSo /= UCLN;
            MauSo /= UCLN;
        }
        public PhanSo tinhTong2PS(PhanSo ps)
        {
            PhanSo t = new PhanSo();
            t.TuSo = TuSo * ps.MauSo + MauSo * ps.TuSo;
            t.MauSo = MauSo * ps.MauSo;
            return t;
        }
        public PhanSo tinhTong2PS(int n)
        {
            PhanSo t = new PhanSo();
            t.TuSo = TuSo + MauSo * n;
            t.MauSo = MauSo;
            return t;
        }
        public double giaTriThuc()
        {
            return (TuSo * 1.0) / MauSo;
        }

    }
}
