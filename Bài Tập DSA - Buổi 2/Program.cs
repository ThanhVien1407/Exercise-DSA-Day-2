using System.Reflection.Metadata.Ecma335;

internal class Program
{
    public class KetQuaMon
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }

        public int SoTinChi { get; set; }

        public double Diem { get; set; }
    }
    public class SinhVien
    {
        public string MaSV { get; set; }
     
        public string HoTen { get; set; }

        public List<KetQuaMon> DanhSachDiem { get; set; } = new List<KetQuaMon>();

        public void ThemDiem(string maMon, string tenMon, int soTinChi, double diem)
        {
            KetQuaMon kq = new KetQuaMon()
            {
                MaMon = maMon,
                TenMon = tenMon,
                SoTinChi = soTinChi,
                Diem = diem
            };
            DanhSachDiem.Add(kq);
        }
        public bool XoaDiem(string maMon)
        {
            for (int i = 0; i < DanhSachDiem.Count; i++)
            {
                if (DanhSachDiem[i].MaMon == maMon)
                {
                    DanhSachDiem.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
    public static void BaiTapDanhSach()
    {
        SinhVien sv = new SinhVien()
        {
            MaSV = "SV01",
            HoTen = "Vo Thanh Vien"
        };
        sv.ThemDiem("DSA", "Cau truc du lieu va giai thuat", 3, 9);
        sv.ThemDiem("CSLT", "Co so lap trinh", 3, 8);

        foreach (KetQuaMon kq in sv.DanhSachDiem)
        {
            Console.Write($"{kq.MaMon} - {kq.TenMon} - ");
            Console.WriteLine($"{kq.SoTinChi} tin chi - diem: {kq.Diem}");
        }
        bool ketqua = sv.XoaDiem("CSLT");

        Console.WriteLine(ketqua ? "Da xoa diem mon CSLT" : "Khong tim thay mon");

    }
    private static void Main(string[] args)
    {
        BaiTapDanhSach();
    }
}