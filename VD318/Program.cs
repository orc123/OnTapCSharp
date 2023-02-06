namespace VD318
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valueOne = 10;
            int valueTwo;
            valueTwo = valueOne++;
            Console.WriteLine($"Thuc hien tang sau: {valueOne}, {valueTwo}");
            valueOne = 20;
            valueTwo = ++valueOne;
            Console.WriteLine($"Thuc hien tang truoc: {valueOne}, {valueTwo}");
        }
    }
}