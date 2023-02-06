namespace VD505
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            // Boxing
            object o = i;
            // Unboxing phải được tường minh
            int k = (int)o;
            Console.WriteLine("k: {0}", k);
        }
    }
}