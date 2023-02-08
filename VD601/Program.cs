namespace VD601
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(3, 4);
            Console.WriteLine("f1:{0}", f1.ToString());

            Fraction f2 = new Fraction(2, 4);
            Console.WriteLine("f2:{0}", f2.ToString());

            Fraction f3 = f1 + f2;
            Console.WriteLine("f1 + f2 = f3:{0}", f3.ToString());

            Fraction f4 = f3 + 5;
            Console.WriteLine("f4 = f3 + 5:{0}", f4.ToString());

            Fraction f5 = new Fraction(2, 4);
            if (f5 == f2)
            {
                Console.WriteLine("f5:{0}==f2:{1}",
                f5.ToString(), f2.ToString());
            }

        }
    }
}