using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Buoi_4_BTCB
{
    internal class CongTy
    {
        private string tenCTy;
        private string diaChi;
        private string soDienThoai;

        public string TenCTy
        {
            get { return tenCTy; }
            set { tenCTy = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        List<NhanVien> danhSachNhanVien;
        public CongTy()
        {
            danhSachNhanVien = new List<NhanVien>();
        }
        public List<NhanVien> DanhSachNhanVien
        {
            get { return danhSachNhanVien; }
            set { danhSachNhanVien = value; }
        }

        public void Nhap(string tenFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tenFile);
            TenCTy = doc.SelectSingleNode("/CongTy/TenCty").InnerText;
            DiaChi = doc.SelectSingleNode("/CongTy/DiaChi").InnerText;
            SoDienThoai = doc.SelectSingleNode("/CongTy/DT").InnerText;
            XmlNodeList dsNV = doc.SelectNodes("/CongTy/DSNV/NV");
            foreach (XmlNode nv in dsNV)
            {
                string maNV = nv.SelectSingleNode("ma").InnerText;
                string tenNV = nv.SelectSingleNode("ten").InnerText;
                int namVaoLam = int.Parse( nv.SelectSingleNode("nvl").InnerText);
                double heSo = double.Parse(nv.SelectSingleNode("hsl").InnerText);
                int soNgayNghi = int.Parse(nv.SelectSingleNode("snn").InnerText);
                if (nv.Attributes["loai"].Value == "1")
                {
                    NhanVien nhanVien = new NhanVien(maNV, tenNV, namVaoLam, heSo, soNgayNghi);
                    danhSachNhanVien.Add(nhanVien);
                }
                else
                {
                    string chucVu = nv.SelectSingleNode("cv").InnerText;
                    double heSoChucVu = double.Parse(nv.SelectSingleNode("hspccv").InnerText);
                    string phongBan = nv.SelectSingleNode("phongban").InnerText;
                    CanBo canBo = new CanBo(maNV, tenNV, namVaoLam, heSo, soNgayNghi, chucVu, heSoChucVu, phongBan);
                    danhSachNhanVien.Add(canBo);
                }
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Cong ty: {0}", TenCTy);
            Console.WriteLine("Dia chi: {0}", DiaChi);
            Console.WriteLine("So dien thoai: {0}", SoDienThoai);
            Console.WriteLine("Danh sach nhan vien:");
            foreach (NhanVien nv in danhSachNhanVien)
            {
                nv.Xuat();
                Console.WriteLine();
            }
        }
    }
}
