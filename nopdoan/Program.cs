using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

//Giao diện
interface IChoiDuoc
{
    void Choi();
}

//Lớp trừu tượng
abstract class TroChoi : IChoiDuoc
{
    public string TenTroChoi { get; protected set; }
    public int SoVong { get; protected set; }

    protected TroChoi(string ten, int soVong = 1)
    {
        TenTroChoi = ten;
        SoVong = soVong;
    }

    // Mỗi trò chơi con phải cài đặt cách chơi 1 vòng
    protected abstract KetQuaTroChoi ChoiMotVong(int soThuTuVong);

    // Triển khai từ giao diện
    public void Choi()
    {
        var dsKetQua = new List<KetQuaTroChoi>();
        for (int i = 1; i <= SoVong; i++)
        {
            Console.WriteLine($"\nVòng {i}/{SoVong}");
            var kq = ChoiMotVong(i);
            dsKetQua.Add(kq);
        }

        // Lưu kết quả vào lịch sử
        QuanLyLichSu.Instance.ThemPhienChoi(new PhienChoi
        {
            TenTroChoi = TenTroChoi,
            ThoiGianChoi = DateTime.Now,
            CacKetQua = dsKetQua
        });

        // In tóm tắt kết quả
        Console.WriteLine("\nKẾT QUẢ VÒNG:");
        for (int i = 0; i < dsKetQua.Count; i++)
        {
            Console.WriteLine($"Vòng {i + 1}: {(dsKetQua[i].Thang ? "Thắng" : "Thua")} (Lượt thử: {dsKetQua[i].SoLanThu})");
        }
    }
}

// Tạo logic cách trò chơi Đoán số chạy
class TroChoiDoanSo : TroChoi
{
    private int GiaTriMin { get; }
    private int GiaTriMax { get; }

    public TroChoiDoanSo(int min = 1, int max = 100, int soVong = 1) : base("Đoán Số", soVong)
    {
        GiaTriMin = min;
        GiaTriMax = max;
    }

    protected override KetQuaTroChoi ChoiMotVong(int soThuTuVong)
    {
        var rd = new Random();
        int soBiMat = rd.Next(GiaTriMin, GiaTriMax + 1);
        int soLanThu = 0;
        int gioiHanThu = 10;

        Console.WriteLine($"Tôi đã nghĩ 1 số trong khoảng [{GiaTriMin}..{GiaTriMax}]. Bạn có tối đa {gioiHanThu} lần đoán.");

        while (soLanThu < gioiHanThu)
        {
            soLanThu++;
            Console.Write($"Lần đoán #{soLanThu}: Nhập 1 số: ");
            string? duLieuNhap = Console.ReadLine();
            
            try
            {
                if (string.IsNullOrWhiteSpace(duLieuNhap))
                    throw new LoiNhapLieuNguoiChoi("Bạn chưa nhập gì. Vui lòng nhập một số.");

                if (!int.TryParse(duLieuNhap.Trim(), out int soDoan))
                    throw new LoiNhapLieuNguoiChoi("Bạn nhập không phải số nguyên hợp lệ.");

                if (soDoan < GiaTriMin || soDoan > GiaTriMax)
                    throw new LoiNhapLieuNguoiChoi($"Số nhập phải trong khoảng [{GiaTriMin}..{GiaTriMax}].");

                if (soDoan == soBiMat)
                {
                    Console.WriteLine($"Chính xác! Bạn đoán đúng sau {soLanThu} lần.");
                    return new KetQuaTroChoi { Thang = true, SoLanThu = soLanThu, GhiChu = "Đã đoán đúng" };
                }
                else if (soDoan < soBiMat)
                {
                    Console.WriteLine("Số cần tìm lớn hơn.");
                }
                else
                {
                    Console.WriteLine("Số cần tìm nhỏ hơn.");
                }
            }
            catch (LoiNhapLieuNguoiChoi ex)
            {
                Console.WriteLine($"Lỗi nhập: {ex.Message} (Lần này vẫn tính là 1 lượt)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Có lỗi bất ngờ: {ex.Message}");
                return new KetQuaTroChoi { Thang = false, SoLanThu = soLanThu, GhiChu = "Lỗi khi chơi" };
            }
        }

        Console.WriteLine($"Hết lượt! Số đúng là: {soBiMat}. Bạn không đoán được.");
        return new KetQuaTroChoi { Thang = false, SoLanThu = soLanThu, GhiChu = $"Không đoán được (số đúng: {soBiMat})" };
    }
}

//Đề phòng xảy ra lỗi khác
class LoiNhapLieuNguoiChoi : Exception
{
    public LoiNhapLieuNguoiChoi(string thongBao) : base(thongBao) { }
}

//Các lớp dữ liệu
class KetQuaTroChoi
{
    public bool Thang { get; set; }
    public int SoLanThu { get; set; }
    public string? GhiChu { get; set; }
}

class PhienChoi
{
    public string? TenTroChoi { get; set; }
    public DateTime ThoiGianChoi { get; set; }
    public List<KetQuaTroChoi>? CacKetQua { get; set; }
}

//Singleton Quản lý lịch sử
class QuanLyLichSu
{
    private static readonly Lazy<QuanLyLichSu> lazy = new(() => new QuanLyLichSu());
    public static QuanLyLichSu Instance => lazy.Value;

    private readonly string duongDanFile = "lich_su.json";
    private List<PhienChoi> cacPhien = new();

    private QuanLyLichSu()
    {
        Tai();
    }

    private void Tai()
    {
        try
        {
            if (!File.Exists(duongDanFile))
            {
                cacPhien = new List<PhienChoi>();
                return;
            }

            string json = File.ReadAllText(duongDanFile);
            cacPhien = JsonSerializer.Deserialize<List<PhienChoi>>(json) ?? new List<PhienChoi>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Không thể đọc file lịch sử: {ex.Message}");
            cacPhien = new List<PhienChoi>();
        }
    }

    public void ThemPhienChoi(PhienChoi p)
    {
        cacPhien.Add(p);
        Luu();
    }

    private void Luu()
    {
        try
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(cacPhien, options);
            File.WriteAllText(duongDanFile, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi lưu lịch sử: {ex.Message}");
        }
    }

    public int TongSoVongChoi()
    {
        int tong = 0;
        foreach (var p in cacPhien)
            tong += p.CacKetQua?.Count ?? 0;
        return tong;
    }

    public int TongSoThang()
    {
        int thang = 0;
        foreach (var p in cacPhien)
            if (p.CacKetQua != null)
                foreach (var kq in p.CacKetQua)
                    if (kq.Thang) thang++;
        return thang;
    }

    public void InThongKe()
    {
        Console.WriteLine("\nLịch sử chơi (tóm tắt)");
        Console.WriteLine($"Tổng số vòng đã chơi: {TongSoVongChoi()}");
        Console.WriteLine($"Tổng số lần thắng: {TongSoThang()}");
        Console.WriteLine($"Số phiên lưu trữ: {cacPhien.Count}");
        Console.WriteLine($"(Dữ liệu lưu ở file: {Path.GetFullPath(duongDanFile)})");
    }
}

//Chương trình chính
class ChuongTrinh
{
    static void Main()
    {
        Console.WriteLine("Chào mừng đến với TRÒ CHƠI ĐOÁN SỐ");

        while (true)
        {
            Console.WriteLine("\nChọn 1: Chơi 1 vòng");
            Console.WriteLine("Chọn 2: Chơi nhiều vòng");
            Console.WriteLine("Chọn 3: Xem tóm tắt lịch sử chơi");
            Console.WriteLine("Chọn 4: Thoát");
            Console.Write("Lựa chọn của bạn: ");
            string? luaChon = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(luaChon))
            {
                Console.WriteLine("Bạn chưa chọn. Vui lòng nhập 1-4.");
                continue;
            }

            if (!int.TryParse(luaChon.Trim(), out int c))
            {
                Console.WriteLine("Không hợp lệ. Hãy nhập 1-4.");
                continue;
            }

            if (c == 4)
            {
                Console.WriteLine("Cám ơn bạn đã chơi. Tạm biệt!");
                break;
            }

            try
            {
                switch (c)
                {
                    case 1:
                        {
                            var g = new TroChoiDoanSo(1, 100, soVong: 1);
                            g.Choi();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Bạn muốn chơi mấy vòng? ");
                            string? strSoVong = Console.ReadLine();
                            if (!int.TryParse(strSoVong, out int soVong) || soVong <= 0)
                            {
                                Console.WriteLine("Số vòng không hợp lệ. Sẽ dùng mặc định 3 vòng.");
                                soVong = 3;
                            }
                            var g = new TroChoiDoanSo(1, 100, soVong);
                            g.Choi();
                            break;
                        }
                    case 3:
                        {
                            QuanLyLichSu.Instance.InThongKe();
                            break;
                        }
                    default:
                        Console.WriteLine("Chỉ chọn 1-4 thôi nhé.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi chạy: {ex.Message}");
            }
        }
    }
}
