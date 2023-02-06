namespace VD407;

public class Time
{
    public Time(DateTime dateTime)
    {
        Year = dateTime.Year;
        Month = dateTime.Month;
        Date = dateTime.Day;
        Hour = dateTime.Hour;
        Minute = dateTime.Minute;
        Second = dateTime.Second;
    }

    private int Year;
    private int Month;
    private int Date;
    private int Hour;
    private int Minute;
    private int Second = 30;

    public void DisplayCurrentTime()
    {
        Console.WriteLine($"{Date}/{Month}/{Year} {Hour}:{Minute}:{Second}");
    }

    public void GetTime(int h, int m, int s)
    {
        h = Hour;
        m = Minute;
        s = Second;
    }
    public int GetHour()
    {
        return Hour;
    }

}
