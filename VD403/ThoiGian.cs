namespace VD403;

public class ThoiGian
{
    public ThoiGian(DateTime dateTime)
    {
        Nam = dateTime.Year;
        Thang = dateTime.Month;
        Ngay = dateTime.Day;
        Gio = dateTime.Hour;
        Phut = dateTime.Minute;
        Giay = dateTime.Second;
    }
    public void ThoiGianHienHanh()
    {
        Console.WriteLine($"Thoi gian hien hanh la: {Ngay}/{Thang}/{Nam} {Gio}:{Phut}:{Giay}");
    }
    int Nam;
    int Thang;
    int Ngay;
    int Gio;
    int Phut;
    int Giay;
}
