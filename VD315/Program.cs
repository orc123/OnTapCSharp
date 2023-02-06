namespace VD315;

public class Program
{
    public static int Main(string[] args)
    {
        int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (var item in intArray)
        {
            Console.WriteLine(item + " ");
        }
        return 0;
    }
}