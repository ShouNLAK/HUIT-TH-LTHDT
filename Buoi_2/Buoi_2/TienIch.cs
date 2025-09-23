using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2
{
    public class TienIch
    {
        public static int tinhUCLN(int a, int b)
        {
            if (a == 0 || b == 0)
                return a + b;
            else
                a = Math.Abs(a);
                b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return a;
        }
    }
}
