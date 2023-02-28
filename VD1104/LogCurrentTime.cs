namespace VD1104;

public class LogCurrentTime
{
    public void Subscrible(Clock theClock)
    {
        theClock.OnSecondChange += new Clock.SecondChangeHandler(WriteToEntry);
    }
    public void WriteToEntry(object theClock, TimeInfoEventArgs ti)
    {
        Console.WriteLine($"Logging to file: {ti.hour.ToString()}:{ti.minute.ToString()}:{ti.second.ToString()}");
    }
}
