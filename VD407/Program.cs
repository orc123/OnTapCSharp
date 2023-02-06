namespace VD407
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = System.DateTime.Now;
            Time t = new Time(currentTime);
            t.DisplayCurrentTime();
            int theHour = 0;
            int theMinute = 0;
            int theSecond = 0;
            t.GetTime(theHour, theMinute, theSecond);
            Console.WriteLine($"Current time {theHour}:{theMinute}:{theSecond}");
        }
    }
}