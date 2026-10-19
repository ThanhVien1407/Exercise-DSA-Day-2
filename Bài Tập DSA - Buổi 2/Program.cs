using System.Reflection.Metadata.Ecma335;
using System.Text;
using static Bài_Tập_DSA___Buổi_2.TEST;

internal class Program
{
    /*public class KetQuaMon
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
    public static void BaiTap010203()
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
    }*/
    public static void BaiTapDanhSach()
    {
        MonHoc mon1 = new MonHoc()
        {
            MaMon = "CSLT",
            TenMon = "Cơ sở lập trình",
            SoTin = 3
        };

        MonHoc mon2 = new MonHoc()
        {
            MaMon = "CSDL",
            TenMon = "Cơ sở dữ liệu",
            SoTin = 3
        };

        SinhVien sv1 = new SinhVien()
        {
            MaSV = "SV01",
            Ten = "Võ Thanh Viễn"
        };

        SinhVien sv2 = new SinhVien()
        {
            MaSV = "SV02",
            Ten = "Nguyễn Văn An"
        };

        sv1.ThemDiem(mon1, 8.5);
        sv1.ThemDiem(mon2, 9.0);
        sv2.ThemDiem(mon2, 8.0);

        List<SinhVien> ds = new List<SinhVien>();
        ds.Add(sv1);
        ds.Add(sv2);

        // In điểm của sv1
        foreach (BangDiemMon kq in sv1.DanhSachDiem)
        {
            Console.WriteLine(
                $"{kq.Mon.MaMon} - {kq.Mon.TenMon} - " +
                $"{kq.Mon.SoTin} tín chỉ - Điểm: {kq.Diem}");
        }

        // Tìm điểm
        double? diem = TimDiem(ds, "SV01", "CSDL");

        if (diem.HasValue)
            Console.WriteLine("Điểm tìm được: " + diem.Value);
        else
            Console.WriteLine("Không tìm thấy kết quả");

        // Xóa điểm
        bool daXoa = sv1.XoaDiem("CSLT");

        Console.WriteLine(
            daXoa ? "Đã xóa điểm môn CSLT" : "Không tìm thấy môn");
    }
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        //BaiTap010203();

        BaiTapDanhSach();
    }
}