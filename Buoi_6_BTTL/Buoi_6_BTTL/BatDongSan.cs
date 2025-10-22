using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_6_BTTL
{
    abstract class BatDongSan
    {
        protected string maSo;
        protected double chieuDai;
        protected double chieuRong;

        public string MaSo
        {
            get { return maSo; }
            set { maSo = value; }
        }
        public double ChieuDai
        {
            get { return chieuDai; }
            set {
                if (value > 0)
                    chieuDai = value;
                else
                    throw new Exception("Sai dinh dang");
            }
        }
        public double ChieuRong
        {
            get { return chieuRong; }
            set
            {
                if (value > 0)
                    chieuRong = value;
                else
                    throw new Exception("Sai dinh dang");
            }
        }
        public BatDongSan(string ma, double cd, double cr)
        {
            MaSo = ma;
            ChieuDai = cd;
            ChieuRong = cr;
        }
        public double TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public abstract double TinhGiaTri();
        public virtual void Xuat()
        {
            Console.Write("{0,-10} | {1,-10} | {2,-10} | {3,-10} | {4,-20}"
                , MaSo, ChieuDai, ChieuRong, TinhDienTich(), TinhGiaTri());
        }

    }
}
