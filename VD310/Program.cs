namespace VD310
{
    public class Program
    {
        public static int Main(string[] args)
        {
            int i = 0;
        lap:
            Console.WriteLine($"i: {i}");
            i++;
            if (i <10)
                goto lap;
            return 0;
        }
    }
}