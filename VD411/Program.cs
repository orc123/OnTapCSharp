namespace VD411
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.DateTime currentTime = System.DateTime.Now;
            Time t = new Time(currentTime);
            t.DisplayCurrentTime();
            // Lấy dữ liệu từ thuộc tính Hour
            int theHour = t.Hour;
            Console.WriteLine($"Retrieved the hour: {theHour}");
            theHour++;
            t.Hour = theHour;
            Console.WriteLine($"Updated the hour: {theHour}");
        }
    }
}