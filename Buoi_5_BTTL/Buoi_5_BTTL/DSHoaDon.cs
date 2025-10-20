using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Buoi_5_BTTL
{
    internal class DSHoaDon
    {
        List<HoaDon> dsHD;
        private string tenCongTy;
        private string dienThoai;
        private string diaChi;
        public List<HoaDon> DSHD
        {
            get { return dsHD; }
            set { dsHD = value; }
        }
        public string TenCongTy
        {
            get { return tenCongTy; }
            set { tenCongTy = value; }
        }
        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public DSHoaDon()
        {
            dsHD = new List<HoaDon>();
        }

        public void Doc_DSHD_XML(string tenFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tenFile);
            TenCongTy = doc.SelectSingleNode("/QuanLy/TenCongTy").InnerText;
            DienThoai = doc.SelectSingleNode("/QuanLy/SDT").InnerText;
            DiaChi = doc.SelectSingleNode("/QuanLy/DiaChi").InnerText;
            XmlNodeList nodeList = doc.SelectNodes("/QuanLy/DSHD/HoaDon");
            foreach(XmlNode node in nodeList)
            {
                string maKH = node["MaKH"].InnerText;
                string tenKH = node["TenKH"].InnerText;
                double soLuong = double.Parse(node["SoLuong"].InnerText);
                double giaBan = double.Parse(node["Gia"].InnerText);
                if (node.Attributes["type"].Value.Equals("1"))
                {
                    double khoangCach = double.Parse(node["KhoangCach"].InnerText);
                    DSHD.Add(new HDKHCaNhan(maKH, tenKH, soLuong, giaBan, khoangCach));
                }
                else if (node.Attributes["type"].Value.Equals("2"))
                {
                    int ThoiGian = int.Parse(node["ThoiGianHT"].InnerText);
                    DSHD.Add(new HDDaiLy(maKH, tenKH, soLuong, giaBan, ThoiGian));
                }
                else if (node.Attributes["type"].Value.Equals("3"))
                {
                    int SoLuongNV = int.Parse(node["SoLuongNV"].InnerText);
                    DSHD.Add(new HDCongTy(maKH, tenKH, soLuong, giaBan, SoLuongNV));
                }
                else
                    throw new Exception("Sai dinh dang Attributes");
            }
        }

        public void Xuat_DSHD()
        {
            Console.WriteLine("{0,-10} | {1,-30} | {2,-10} | {3,-20} | {4,-20} | {5,-20}",
                "Ma KH", "Ten KH", "So Luong", "Gia ban", "Chiet Khau", "Thanh Tien");
            foreach (HoaDon node in DSHD)
                node.Xuat();
        }

        public double TinhTongTien()
        {
            return DSHD.Sum(t => t.TinhThanhTien());
        }
        public List<HoaDon> KhachHangMuaNhieuNhat()
        {           
            double max = DSHD.Max(t=>t.SoLuong);
            //foreach (HoaDon node in DSHD)
            //    if (node.SoLuong == max)
            //        KQ.Add(node);
            List<HoaDon> dsKHMuaNhieuNhat=DSHD.Where(t=>t.SoLuong==max).ToList();
            return dsKHMuaNhieuNhat;
        }
        public List<HDCongTy> LocHDCTy()
        {
            //List<HDCongTy> KQ = new List<HDCongTy>();
            //foreach (HoaDon node in DSHD)
            //    if (node is HDCongTy)
            //        KQ.Add((HDCongTy)node);
            List<HDCongTy> dshdcty= DSHD.OfType<HDCongTy>().ToList();
            return dshdcty;
        }
        public double TinhTongChietKhau_HDCTy()
        {
            return LocHDCTy().Sum(t => t.TinhChietKhau());
        }
        public List<HDDaiLy> LocHDDaiLy()
        {
            List<HDDaiLy> KQ = DSHD.OfType<HDDaiLy>().ToList();
            return KQ;
        }
        public List<HoaDon> sapXep_TDSoLuong_GDThanhTien()
        {
            List<HoaDon> KQ = new List<HoaDon>();
            KQ = DSHD.OrderBy(t => t.SoLuong).ThenByDescending(t => t.TinhThanhTien()).ToList();
            return KQ;
        }
        public List<HoaDon> TimMaKH(string x)
        {
            List<HoaDon> KQ =DSHD.Where(obj=>obj.MaKH==x).ToList();            
            return KQ;
        }
    }
}
