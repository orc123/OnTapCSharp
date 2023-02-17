namespace VD901;

internal class Program
{
    static void Main(string[] args)
    {
        int[] intArray;
        Employee[] empArray;

        intArray = new int[5];
        empArray = new Employee[3];

        for (int i = 0; i < empArray.Length; i++)
        {
            empArray[i] = new Employee(i + 5);
        }

        for (int i = 0; i < intArray.Length; i++)
        {
            Console.Write(intArray[i].ToString() + "\t");
        }

        for (int i = 0; i < empArray.Length; i++)
        {
            Console.Write(empArray[i].ToString() + "\t");
        }
    }
}