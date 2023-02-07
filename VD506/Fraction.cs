using System.Text;

namespace VD506;

public class Fraction
{
    private int numerator;
    private int denominator;
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public override string ToString()
    {
        StringBuilder s = new StringBuilder();
        s.AppendFormat($"{numerator}/{denominator}");
        return s.ToString();
    }

    internal class FractionArtist
    {
        public void Draw(Fraction f)
        {
            Console.WriteLine("Drawing the numerator {0}", f.numerator);
            Console.WriteLine("Drawing the denominator {0}", f.denominator);
        }
    }
}
