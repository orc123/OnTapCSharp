namespace VD908;

public class Program
{
    static void Main(string[] args)
    {
        string[] myArray =
        {
            "Who", "is", "Kitty", "Mun"
        };

        PrintArray(myArray);
        Array.Reverse(myArray);
        PrintArray(myArray);

        string[] myOtherArray =
        {
            "Chung", "toi", "la", "nhung", "nguoi",
            "lap", "trinh", "may", "tinh"
        };

          PrintArray(myOtherArray);
        Array.Sort(myOtherArray);
        PrintArray(myOtherArray);
    }

    private static void PrintArray(object[] theArray)
    {
        Console.WriteLine("Contents of the Array: {0}", theArray.ToString());

        foreach (object obj in theArray)
        {
            Console.WriteLine($"Value: {obj}");
        }
    }
}