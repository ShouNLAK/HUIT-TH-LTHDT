using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Buoi_5_BTVN
{
    internal class DanhSachHoaDon
    {
        List<HoaDon> dshd;
        public DanhSachHoaDon()
        {
            dshd = new List<HoaDon>();
        }
        public List<HoaDon> DSHD
        {
            get { return dshd; }
            set { dshd = value; }
        }

        public void Nhap_XML(string tenFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tenFile);
            XmlNodeList nodeList = doc.SelectNodes("/DanhSach/HoaDon");
            foreach (XmlNode node in nodeList)
            {
                string ma = node["MaKH"].InnerText;
                string ten = node["TenKH"].InnerText;
                DateTime ngay = DateTime.Parse(node["NgayLap"].InnerText);
                double sl = double.Parse(node["SoLuong"].InnerText);
                XmlNode matHangNode = node["MatHang"];
                string maHang = matHangNode["MaHang"].InnerText;
                string tenHang = matHangNode["TenHang"].InnerText;
                double donGia = double.Parse(matHangNode["DonGia"].InnerText);
                MatHang mh = new MatHang(maHang, tenHang, donGia);
                if (node.Attributes["loai"].Value.Equals("VIP"))
                    DSHD.Add(new HoaDonKhachVIP(ma, ten, ngay, mh, sl));
                else if (node.Attributes["loai"].Value.Equals("TT"))
                    DSHD.Add(new HoaDonKhachThanThiet(ma, ten, ngay, mh, sl));
                else if (node.Attributes["loai"].Value.Equals("VL"))
                    DSHD.Add(new HoaDonKhachVangLai(ma, ten, ngay, mh, sl));
                else
                    throw new Exception("Loai khach hang khong hop le");
            }
        }

        public void Xuat()
        {
            Console.WriteLine("{0,-10} | {1,-20} | {2,-19} | {3,-10} - {4,-20} - {5,-10} | {6,-10} | {7,-10} | {8,-10} | {9,-10}",
                "MaKH", "TenKH", "NgayLap", "MaHang", "TenHang", "DonGia", "SoLuong", "ThanhTien", "KhuyenMai", "TriGia");
            foreach (HoaDon hd in DSHD)
            {
                hd.Xuat();
                Console.WriteLine();
            }
        }

        public List<HoaDonKhachVangLai> HoaDonKhachVangLai()
        {
            return DSHD.OfType<HoaDonKhachVangLai>().ToList();
        }
        public double TongTriGia()
        {
            return DSHD.Sum(hd => hd.TinhTriGia());
        }
        public List<HoaDon> MaxTriGia()
        {
            double maxTriGia = DSHD.Max(hd => hd.TinhTriGia());
            return DSHD.Where(hd => hd.TinhTriGia() == maxTriGia).ToList();
        }
        public int Dem_HD_VIP_TT()
        {
            return DSHD.Count(hd => hd is HoaDonKhachVIP || hd is HoaDonKhachThanThiet);
        }
        public List<HoaDon> sapXep_TDTriGia_GDMaSo()
        {
            return DSHD.OrderBy(hd => hd.TinhTriGia()).ThenByDescending(hd => hd.MaSo).ToList();
        }
    }
}
