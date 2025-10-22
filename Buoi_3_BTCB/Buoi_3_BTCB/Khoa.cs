using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Buoi_3_BTCB
{
    internal class Khoa
    {
        private string tenKhoa;
        private string viTri;
        private string soDienThoai;
        private int soNganh;
        List<GiangVien> lstGV;
        public List<GiangVien> LSTGV
        {
            get { return lstGV; }
            set { lstGV = value; }
        }
        public Khoa()
        {
            lstGV = new List<GiangVien>();
        }
        public void DocDSGiangVien(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            tenKhoa = read.SelectSingleNode("/Khoa/TenKhoa").InnerText;
            viTri = read.SelectSingleNode("/Khoa/ViTri").InnerText;
            soDienThoai = read.SelectSingleNode("/Khoa/SDT").InnerText;
            soNganh = int.Parse(read.SelectSingleNode("/Khoa/SoNganh").InnerText);
            XmlNodeList nodeList = read.SelectNodes("/Khoa/DSGV/GiangVien");
            foreach (XmlNode node in nodeList)
            {
                GiangVien gVien = new GiangVien();
                gVien.HoTen = node["HoTen"].InnerText;
                gVien.SoNhomHD = int.Parse(node["SoNhom"].InnerText);
                lstGV.Add(gVien);
            }
        }
        public void XuatDSGiangVien()
        {
            Console.WriteLine("Thong tin KHoa : ");
            Console.WriteLine("Ten Khoa: {0}", tenKhoa);
            Console.WriteLine("Vi tri: {0}", viTri);
            Console.WriteLine("So dien thoai: {0}", soDienThoai);
            Console.WriteLine("So nganh: {0}", soNganh);
            Console.WriteLine("Danh sach giang vien: ");
            Console.WriteLine("Ho ten \t\t So nhom HD");
            foreach (GiangVien gv in lstGV)
            {
                gv.xuat();
            }
        }
        public int TinhTongNhomHD()
        {
            return LSTGV.Sum(gvhd => gvhd.SoNhomHD);
        }
        public void SXTangDanHoTen()
        {
            LSTGV = LSTGV.OrderBy(gvhd => gvhd.HoTen).ToList();
        }
        public void SXGiamDanNhomHD()
        {
            LSTGV = LSTGV.OrderByDescending(gvhd => gvhd.SoNhomHD).ToList();
        }
        public List<GiangVien> LocSoNhomLonHon1()
        {
            return LSTGV.Where(gvhd => gvhd.SoNhomHD > 1).ToList();
        }
        
    }
}
