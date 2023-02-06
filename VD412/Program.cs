namespace VD412;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This year: {0}", Time.Year.ToString());
        Time.Year = 2024;
        Console.WriteLine("This year: {0}", Time.Year.ToString());
    }
}

public  class Time
{
    static Time()
    {
        DateTime dateTime = DateTime.Now;
        Year = dateTime.Year;
        Month = dateTime.Month;
        Date = dateTime.Day;
        Hour = dateTime.Hour;
        Minute = dateTime.Minute;
        Second = dateTime.Second;
    }
    public static int Year;
    public static int Month;
    public static int Date;
    public static int Hour;
    public static int Minute;
    public static int Second;
}