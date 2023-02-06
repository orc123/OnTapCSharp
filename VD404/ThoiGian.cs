
namespace VD404;

public class ThoiGian
{
    public void ThoiGianHienHanh()
    {
        System.DateTime now = System.DateTime.Now;
        System.Console.WriteLine("\n Hien tai: \t {0}/{1}/{2} {3}:{4}:{5}",now.Day, now.Month, now.Year, now.Hour, now.Minute, now.Second);
        System.Console.WriteLine("Thoi Gian:\t {0}/{1}/{2} {3}:{4}:{5}",Ngay, Thang, Nam, Gio, Phut, Giay);
    }

    public ThoiGian(DateTime dateTime)
    {
        Nam = dateTime.Year;
        Thang = dateTime.Month;
        Ngay = dateTime.Day;
        Gio = dateTime.Hour;
        Phut = dateTime.Minute;
        Giay = dateTime.Second;
    }

    public ThoiGian(int year, int month, int date, int hour, int minute)
    {
        Nam = year;
        Thang = month;
        Ngay = date;
        Gio = hour;
        Phut = minute;
    }

    private int Nam;
    private int Thang;
    private int Ngay;
    private int Gio;
    private int Phut;
    private int Giay = 30;
}
