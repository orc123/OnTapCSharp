using System.Collections;

namespace VD912;

internal class Program
{
    static void Main(string[] args)
    {
        ArrayList empArray = new ArrayList();
        ArrayList intArray = new ArrayList();

        for (int i = 0; i < 5; i++)
        {
            empArray.Add(new Employee(i + 100));
            intArray.Add(i * 5);
        }

        for (int i = 0; i < intArray.Count; i++)
        {
            Console.Write(intArray[i].ToString() + " ");
        }

        Console.WriteLine("\n");

        for (int i = 0; i < empArray.Count; i++)
        {
            Console.Write(empArray[i].ToString() + " ");
        }

        Console.WriteLine("\n");
        Console.WriteLine("empArray.Count: " + empArray.Count);
        Console.WriteLine("empArray.Capacity: " + empArray.Capacity);
    }
}