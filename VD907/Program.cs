namespace VD907
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] myEmployeeArray = new Employee[3];

            for (int i = 0; i < 3; i++)
            {
                myEmployeeArray[i] = new Employee(i + 5);
            }
            PrintArray(myEmployeeArray);

            string[] array = { "hello", "world" };

            PrintArray(array);
        }

        public static void PrintArray(object[] theArray)
        {
            Console.WriteLine("Contents of the Array: {0}", theArray.ToString());

            foreach (object obj in theArray)
            {
                Console.WriteLine($"Value: {obj}");
            }
        }
    }
}