using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_3_BTCB
{
    internal class GiangVien
    {
        private string hoTen;
        private int soNhomHD;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public int SoNhomHD
        {
            get { return soNhomHD; }
            set { soNhomHD = value; }
        }
        public GiangVien()
        {
        }
        public GiangVien(string hoTen, int soNhomHD)
        {
            this.hoTen = hoTen;
            this.soNhomHD = soNhomHD;
        }
        public void xuat()
        {
            Console.WriteLine("{0} \t\t {1}",HoTen,SoNhomHD);
        }
    }
}
