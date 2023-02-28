namespace VD1104;

public class DisplayClock
{
    public void Subscrible(Clock theClock)
    {
        theClock.OnSecondChange += new Clock.SecondChangeHandler(TimeHasChanged);
    }
    public void TimeHasChanged(object theClock, TimeInfoEventArgs ti)
    {
        Console.WriteLine($"Current time: {ti.hour.ToString()}:{ti.minute.ToString()}:{ti.second.ToString()}");
    }
}