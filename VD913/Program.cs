using System.Collections;

namespace VD913
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList empArray = new ArrayList();
            ArrayList intArray = new ArrayList();

            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                empArray.Add(new Employee(r.Next(10) + 100));
                intArray.Add(r.Next(10));
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

            intArray.Sort();
            for (int i = 0; i < intArray.Count; i++)
            {
                Console.Write(intArray[i].ToString() + " ");
            }

            Console.WriteLine("\n");
            empArray.Sort();

            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write(empArray[i].ToString() + " ");
            }

        }
    }
}