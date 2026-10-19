using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Bài_Tập_DSA___Buổi_2
{
    public class TEST
    {
        public class MonHoc
        {
            public string MaMon { get; set; }
            public string TenMon { get; set; }
            public int SoTin { get; set; }
        }
        public class BangDiemMon
        {
            public MonHoc Mon { get; set; }
            public double Diem { get; set; }
        }
        public class SinhVien
        {
            public string MaSV { get; set; }
            public string Ten { get; set; }
            public List<BangDiemMon> DanhSachDiem { get; set; } = new List<BangDiemMon>();
            public void ThemDiem(MonHoc mon, double diem)
            {
                BangDiemMon kq = new BangDiemMon()
                {
                    Mon = mon,
                    Diem = diem
                };
                DanhSachDiem.Add(kq);   
            }
            public bool XoaDiem(string maMon)
            {
                for (int i = 0; i < DanhSachDiem.Count; i++)
                {
                    if (DanhSachDiem[i].Mon.MaMon == maMon) 
                    {
                        DanhSachDiem.RemoveAt(i);
                        return true;
                    }
                }
                return false;
            }
        }
        public static double ? TimDiem(List<SinhVien> ds, string maSV, string maMon)
        {
            foreach (SinhVien sv in ds)
            {
                if (sv.MaSV == maSV)
                {
                    foreach (BangDiemMon kq in sv.DanhSachDiem)
                    {
                        if (kq.Mon.MaMon == maMon)
                        {
                            return kq.Diem;
                        }
                    }
                    return null;
                }
            }
            return null;
        }
    }   
}
