using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Buoi_2
{
    internal class DanhSachPS
    {
        List<PhanSo> lstPhanSo;
        public List<PhanSo> LstPhanSo
        {
            get { return lstPhanSo; }
            set { lstPhanSo = value; }
        }
        public DanhSachPS()
        {
            LstPhanSo = new List<PhanSo>();
        }
        public DanhSachPS (List<PhanSo> lstPhanSo)
        {
            LstPhanSo = lstPhanSo;
        }
        public void nhap()
        {
            Console.Write("Nhap so luong phan so : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan so #{0} : ", i);
                PhanSo x = new PhanSo();
                x.nhap();
                LstPhanSo.Add(x);
            }
        }
        public void xuat()
        {
            foreach (PhanSo x in LstPhanSo)
            {
                x.xuat();
            }
            Console.WriteLine();
        }
        public void toiGianDS()
        {
            foreach (PhanSo x in LstPhanSo)
            {
                x.toiGianPS();
            }
        }
        public bool timPS (PhanSo x)
        {
            PhanSo k = LstPhanSo.Find(t=>t.MauSo == x.MauSo && t.TuSo == x.TuSo);
            if (k != null)
                return true;
            return false;
        }
        public DanhSachPS sortGiaTri()
        {
            DanhSachPS kq = new DanhSachPS();
            kq.LstPhanSo = LstPhanSo.OrderBy(t=>t.giaTriThuc()).ToList();
            return kq;
        }
        public DanhSachPS locGiaTriLonHon1()
        {
            DanhSachPS kq = new DanhSachPS();
            kq.LstPhanSo = LstPhanSo.Where(t => t.giaTriThuc() > 1.0).ToList();
            return kq;
        }
        public PhanSo max()
        {
            double max = LstPhanSo.Max(t => t.giaTriThuc());
            return LstPhanSo.FirstOrDefault(x => x.giaTriThuc() == max);
        }
        public DanhSachPS Top3DS()
        {
            DanhSachPS kq = new DanhSachPS();
            kq.LstPhanSo = LstPhanSo.OrderByDescending(t=>t.giaTriThuc()).Take(3).ToList();
            return kq;
        }

    }
}
