namespace VD408
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.DateTime currentTime = System.DateTime.Now;
            Time t = new Time(currentTime);
            t.DisplayCurrentTime();
            int theHour = 3;
            int theMinute;
            int theSecond = 20;
            t.SetTime(theHour, out theMinute, ref theSecond);
            Console.WriteLine("The Minute is now: {0} and {1} seconds ",
            theMinute, theSecond);
            theSecond = 45;
            t.SetTime(theHour, out theMinute, ref theSecond);
            Console.WriteLine("The Minute is now: {0} and {1} seconds",
            theMinute, theSecond);
        }
    }
}