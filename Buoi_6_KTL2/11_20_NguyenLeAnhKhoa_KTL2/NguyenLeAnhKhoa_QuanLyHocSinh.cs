using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _11_20_NguyenLeAnhKhoa_KTL2
{
    internal class NguyenLeAnhKhoa_QuanLyHocSinh
    {
        private string tenTruong;
        public string TenTruong
        { 
            get { return tenTruong; } 
            set { tenTruong = value; } 
        }

        List<NguyenLeAnhKhoa_HocSinh> dshs;
        public NguyenLeAnhKhoa_QuanLyHocSinh()
        {
            dshs = new List<NguyenLeAnhKhoa_HocSinh>();
        }
        public List<NguyenLeAnhKhoa_HocSinh> DSHS
        {
            get { return dshs; }
            set {  dshs = value; }
        }

        public void Nhap_DS_XML(string tenFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tenFile);
            TenTruong = doc.SelectSingleNode("/Truong/TenTruong").InnerText;
            XmlNodeList nodeLists = doc.SelectNodes("/Truong/HoaDons/HoaDon");
            foreach (XmlNode node in nodeLists)
            {
                string ma = node["Ma"].InnerText;
                string ten = node["Ten"].InnerText;
                int khoi = int.Parse(node["KhoiLop"].InnerText);
                int soBuoiNghi = int.Parse(node["Nghi"].InnerText);
                if (node.Attributes["loai"].Value.Equals("1"))
                {
                    int soBuoiHocKN = int.Parse(node["HocKN"].InnerText);
                    DSHS.Add(new NguyenLeAnhKhoa_HSMotBuoi(ma, ten, khoi, soBuoiNghi, soBuoiHocKN));
                }
                else if (node.Attributes["loai"].Value.Equals("2"))
                {
                    string dangKy_TABN = node["English"].InnerText;
                    DSHS.Add(new NguyenLeAnhKhoa_HSBanTru(ma, ten, khoi, soBuoiNghi, dangKy_TABN));
                }
                else if (node.Attributes["loai"].Value.Equals("3"))
                    DSHS.Add(new NguyenLeAnhKhoa_HSTiengAnhTangCuong(ma, ten, khoi, soBuoiNghi));
                else
                    throw new Exception("Khai bao sai Attributes (Chi nhan 1 - 2 - 3");
            }
        }
        public void Xuat()
        {
            Console.WriteLine("{0,-10} | {1,-20} | {2,-5} | {3,-10} | {4,-15} | {5,-15} | {6,-15} | {7}",
                "Ma HS", "Ten HS", "Khoi", "So buoi nghi", "Hoc phi", "chi phi khac", "Tong tien", "Thong tin them");
            foreach (NguyenLeAnhKhoa_HocSinh node in DSHS)
            {
                node.Xuat();
                Console.WriteLine();
            }
        }

        public double TinhTong_Tien()
        {
            return DSHS.Sum(t=>t.TongTien());
        }
        public List<NguyenLeAnhKhoa_HocSinh> sapXep_TDKhoiLop_GDTongTien()
        {
            return DSHS.OrderBy(t=>t.KhoiLop).ThenByDescending(t=>t.TongTien()).ToList();
        }
        public double TinhTong_TienCSVC()
        {
            List<NguyenLeAnhKhoa_HSBanTru> x = DSHS.OfType<NguyenLeAnhKhoa_HSBanTru>().ToList();
            List<NguyenLeAnhKhoa_HSTiengAnhTangCuong> y = DSHS.OfType<NguyenLeAnhKhoa_HSTiengAnhTangCuong>().ToList();
            return x.Sum(t=>t.TinhChiPhi_CSVC()) + y.Sum(t=>t.TinhChiPhi_CSVC());
        }
        public double TinhTong_Tien_HSTiengAnhTangCuong()
        {
            List<NguyenLeAnhKhoa_HSTiengAnhTangCuong> x = DSHS.OfType<NguyenLeAnhKhoa_HSTiengAnhTangCuong>().ToList();
            return x.Sum(t => t.TongTien());
        }
        public NguyenLeAnhKhoa_HocSinh Tim_HS_TheoMa(string ma)
        {
            return DSHS.Where(t => t.MaHS == ma).FirstOrDefault();
        }
    }
}
