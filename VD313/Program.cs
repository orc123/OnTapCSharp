namespace VD313;

public class Program
{
    public static int Main(string[] args)
    {
        for (int i = 0; i < 30; i++)
        {
            if (i % 10 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.Write(i + " ");
            }
        }
        return 0;
    }
}