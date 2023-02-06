namespace VD306
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ham Main chuan bi goi ham Func()...");
            Func();
            Console.WriteLine("Tro lai ham Main()");
        }

        static void Func()
            => Console.WriteLine("--->Toi la ham Func()...");
    }
}