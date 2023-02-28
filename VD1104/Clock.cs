namespace VD1104;

public class Clock
{
    public readonly int hour;
    public readonly int minute;
    public readonly int second;

    public delegate void SecondChangeHandler(object clock, TimeInfoEventArgs timeInformation);
    public event SecondChangeHandler OnSecondChange; 

    public void Run()
    {
        for (; ; )
        {
            Thread.Sleep(10);
            DateTime dt = DateTime.Now;
            if (dt.Second != second)
            {
                TimeInfoEventArgs timeInfoEventArgs = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);
                OnSecondChange(this, timeInfoEventArgs);
            }
        }
    }
}
