namespace VD312;

public class Program
{
    public static int Main(string[] args)
    {
        int i = 11;
        do
        {
            Console.WriteLine($"i: {i}");
            i++;
        }
        while (i < 10);
        return 0;
    }
}