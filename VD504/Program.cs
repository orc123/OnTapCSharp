namespace VD504
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            Console.WriteLine("The value of i is: {0}", i.ToString());

            SomeClass s = new SomeClass(7);
            Console.WriteLine("The value of s is: {0}", s.ToString());

            Console.WriteLine("The value of 5 is {0}", 5.ToString());
        }
    }
}