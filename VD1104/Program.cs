namespace VD1104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            DisplayClock displayClock = new DisplayClock();

            displayClock.Subscrible(clock);

            LogCurrentTime logCurrentTime = new LogCurrentTime();
            logCurrentTime.Subscrible(clock);

            clock.Run();
        }
    }
}