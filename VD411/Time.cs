namespace VD411;

public class Time
{
    public Time(DateTime dateTime)
    {
        year = dateTime.Year;
        month = dateTime.Month;
        date = dateTime.Day;
        hour = dateTime.Hour;
        minute = dateTime.Minute;
        second = dateTime.Second;
    }

    public void DisplayCurrentTime()
    {
        Console.WriteLine($"Time\t {date}/{month}/{year} {hour}:{minute}:{second}");
    }

    public int Hour
    {
        get
        {
            return hour;
        }
        set
        {
            hour = value;
        }
    }

    private int year;
    private int month;
    private int date;
    private int hour;
    private int minute;
    private int second;
}
