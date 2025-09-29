using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2_BTVN
{
    public class HoaDon
    {
        private string maHD;
        private string tenKH;
        List<ChiTietBH> dsChiTiet;
        public string MaHD
        {
            get { return maHD; }
            set { maHD = value;}
        }
        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public List<ChiTietBH> DanhSachCT
        {
            get { return dsChiTiet; }
            set { dsChiTiet = value; }
        }
        public HoaDon()
        {
            DanhSachCT = new List<ChiTietBH>();
        }
        public HoaDon(string maHD, string tenKH, List<ChiTietBH> obj)
        {
            MaHD = maHD;
            TenKH = tenKH;
            DanhSachCT = obj;
        }
        public void nhap()
        {
            Console.Write("Nhap ma hoa don: ");
            MaHD = Console.ReadLine();

            Console.Write("Nhap ten khach hang ");
            TenKH = Console.ReadLine();

            Console.Write("Nhap so luong chi tiet ban hang: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap chi tiet hoa don so {0}:",i+1);
                ChiTietBH ct = new ChiTietBH();
                ct.nhap();
                DanhSachCT.Add(ct);
            }
        }
        public void xuat()
        {
            Console.WriteLine("========== THONG TIN HOA DON ==========");
            Console.WriteLine("Ma hoa don  : {0}",MaHD);
            Console.WriteLine("Khach hang  : {0}",TenKH);
            Console.WriteLine("So mat hang : {0}", DanhSachCT.Count());
            Console.WriteLine("MaSP\tTenSP\tGiaBan\tSoLuong\tThanhTien");
            foreach (ChiTietBH x in dsChiTiet)
            {
                x.xuat();
            }
            Console.WriteLine("Tong gia tri hoa don: {0}",TinhTriGia());
            Console.WriteLine("San pham co thanh tien lon nhat : {0}",TimSanPhamMax().TenSP);
        }
        public double TinhTriGia()
        {
            return DanhSachCT.Sum(ct => ct.tinh_ThanhTien());
        }

        public List<ChiTietBH> sapXep()
        {
            return DanhSachCT.OrderByDescending(ct => ct.tinh_ThanhTien()).ThenBy(ct => ct.GiaBan).ToList();
        }
        public ChiTietBH TimSanPhamMax()
        {
            return DanhSachCT.OrderByDescending(ct => ct.tinh_ThanhTien()).ThenBy(ct => ct.GiaBan).First();
        }
    }
}
