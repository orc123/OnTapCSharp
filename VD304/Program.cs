namespace VD304
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int doSoi = 100; // Độ C
            const int doDong = 0; // Độ C

            Console.WriteLine("Do dong cua nuoc {0}", doDong);
            Console.WriteLine("Do soi cua nuoc {0}", doSoi);

            //doSoi = 200; Error CS0131  The left-hand side of an assignment must be a variable, property or indexer VD304 E:\OnTapCSharp\OnTapCSharp\VD304\Program.cs 13  Active

        }
    }
}