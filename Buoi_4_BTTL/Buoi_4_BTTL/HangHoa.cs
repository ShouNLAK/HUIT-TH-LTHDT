using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_BTTL
{
    internal class HangHoa
    {
        protected string maHang;
        protected string tenHang;
        
        public string MaHang
        {
            get { return maHang; }
            set 
            {
                if (value.Length == 5 && value.StartsWith("HH") && value.Substring(2).All(char.IsDigit))
                    maHang = value;
                else
                    maHang = "HH001";
            }
        }

        public HangHoa(string ma, string ten)
        {
            MaHang = ma;
            tenHang = ten;
        }
        public virtual void Xuat()
        {
            Console.Write("{0,-8} | {1,-15} |", MaHang, tenHang);
        }
    }
}
