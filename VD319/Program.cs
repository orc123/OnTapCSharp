namespace VD319
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1;
            int value2;
            int maxValue;
            value1 = 10;
            value2 = 20;
            maxValue = value1 > value2 ? value1 : value2;
            Console.WriteLine("Gia tri thu nhat {0}, gia tri thu hai {1}, gia tri lon nhat {2}", value1, value2, maxValue);

        }
    }
}