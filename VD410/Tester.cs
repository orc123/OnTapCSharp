namespace VD410;

public class Tester
{
    public void Test()
    {
        int x = 5;
        int y = Triple(x);
        Console.WriteLine($"x: {x}, y: {y}");
        long lx = 10;
        long ly = Triple(lx);
        Console.WriteLine($"lx: {lx}, ly: {ly}");
    }
    private int Triple(int val)
    {
        return 3 * val;
    }

    private long Triple(long val)
    {
        return 3 * val;
    }
}
