using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2
{
    public class DanhSachNV
    {
        List<NhanVien> dSNhanVien;
        public List<NhanVien> DSnhanvien
        {
            get { return dSNhanVien; }
            set { dSNhanVien = value; }
        }
        public DanhSachNV()
        {
            DSnhanvien = new List<NhanVien>();
        }
        public DanhSachNV(List<NhanVien> ds)
        {
            DSnhanvien = ds;
        }
        public void nhap()
        {
            Console.Write("Nhap so luong nhan vien : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap nhan vien #{0} : ", i);
                NhanVien x = new NhanVien();
                x.nhap();
                DSnhanvien.Add(x);
            }
        }
        public void xuat()
        {
            Console.WriteLine("Ma NV | Ten NV | He so luong | Nam vao lam | He so phu cap | Luong co ban | Luong NV");
            foreach (NhanVien x in DSnhanvien)
            {
                x.xuat();
            }
            Console.WriteLine();
        }
        public double SumList()
        {
            return DSnhanvien.Sum(t => t.luongNV());
        }
        public NhanVien MaxList()
        {
            double max = DSnhanvien.Max(t => t.luongNV());
            NhanVien KQ = DSnhanvien.FirstOrDefault(x => x.luongNV() == max);
            return KQ;
        }
        public DanhSachNV sortNamVaoLam()
        {
            DanhSachNV kq = new DanhSachNV();
            kq.DSnhanvien = DSnhanvien.OrderBy(t => t.NamVaoLam).ToList();
            return kq;
        }
    }
}
