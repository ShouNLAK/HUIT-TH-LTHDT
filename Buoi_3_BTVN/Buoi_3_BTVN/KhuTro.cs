using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Buoi_3_BTVN
{
    internal class KhuTro
    {
        private string tenTro;
        private string diaChi;

        public string TenTro
        {
            get { return tenTro; }
            set { tenTro = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        List<PhongTro> dsPhong;
        public KhuTro()
        {
            dsPhong = new List<PhongTro>();
        }
        public List<PhongTro> DanhSachPhong
        {
            get { return dsPhong; }
            set { dsPhong = value; }
        }
        public void nhap(string tenFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tenFile);
            this.TenTro = doc.SelectSingleNode("/KhuTro/Ten").InnerText;
            this.DiaChi = doc.SelectSingleNode("/KhuTro/DiaChi").InnerText;
            XmlNodeList nodeList = doc.SelectNodes("/KhuTro/dsPhong/Phong");
            foreach (XmlNode node in nodeList)
            {
                string maPhong = node["MaP"].InnerText;
                int soLuongNguoi = int.Parse(node["SoLuong"].InnerText);
                double giaThue = double.Parse(node["Gia"].InnerText);
                int soDien = int.Parse(node["SoDien"].InnerText);
                int coMayLanh = int.Parse(node["Loai"].InnerText);
                PhongTro pt = new PhongTro(maPhong, soLuongNguoi, giaThue, soDien, coMayLanh);
                DanhSachPhong.Add(pt);
            }
        }
        public void xuat()
        {
            Console.WriteLine("Ten tro: {0}", this.tenTro);
            Console.WriteLine("Dia chi: {0}", this.diaChi);
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-12} {5,-15} {6,-15} {7,-15}",
                "Ma phong", "So nguoi", "Gia thue", "So dien", "Co may lanh", "Tien dien", "Tien may lanh", "Tien phong");
            foreach (PhongTro pt in dsPhong)
            {
                pt.xuat();
            }
        }
        public double tinhTongTien()
        {
            return DanhSachPhong.Sum(pt => pt.tinhTienPhong());
        }
        public KhuTro sapXep_GDTheoSoLuongKhach_GDTheoTienPhong()
        {
            KhuTro kq = new KhuTro();
            kq.DanhSachPhong = DanhSachPhong.OrderByDescending(pt => pt.SoLuongNguoi).ThenByDescending(pt => pt.tinhTienPhong()).ToList();
            return kq;
        }
        public PhongTro max_SoDien()
        {
            return DanhSachPhong.Where(pt => pt.SoDien == DanhSachPhong.Max(p => p.SoDien)).FirstOrDefault();
        }
    }
}
