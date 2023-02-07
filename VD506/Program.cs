namespace VD506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(3, 4);
            Console.WriteLine("f1: " + f1.ToString());

            Fraction.FractionArtist fa = new Fraction.FractionArtist();
            fa.Draw(f1);
        }
    }
}