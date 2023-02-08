namespace VD601;

public class Fraction
{
    private int numerator;
    private int denominator;
    public Fraction(int wholeNumber)
    {
        Console.WriteLine($"In Fraction Constructor(int)");
        this.numerator = wholeNumber;
        this.denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        Console.WriteLine($"In Fraction Constructor(int, int)");
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public static implicit operator Fraction(int theInt)
    {
        Console.WriteLine("In implicit conversion to Fraction");
        return new Fraction(theInt);
    }
    public static explicit operator int(Fraction theFraction)
    {
        Console.WriteLine("In explicit conversion to int");
        return theFraction.numerator / theFraction.denominator;
    }
    public static bool operator == (Fraction lhs, Fraction rhs)
    {
        Console.WriteLine("In operator ==");
        if (lhs.numerator == rhs.numerator && lhs.denominator == rhs.numerator)
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(Fraction lhs, Fraction rhs)
    {
        Console.WriteLine("In operator !=");
        return !(lhs == rhs);
    }

    public override bool Equals(object o)
    {
        Console.WriteLine("In method Equals");
        if (!(o is Fraction))
        {
            return false;
        }
        return this == (Fraction)o;
    }
    public static Fraction operator +(Fraction lhs, Fraction rhs)
    {
        Console.WriteLine("In operator +");
        if (lhs.denominator == rhs.denominator)
        {
            return new Fraction(lhs.numerator + rhs.numerator, lhs.denominator);
        }
        //thực hiện khi hai mẫu số khộng bằng nhau
        int firstProduct = lhs.numerator * rhs.denominator;
        int secondProduct = rhs.numerator * lhs.denominator;
        return new Fraction(firstProduct + secondProduct,
        lhs.denominator * rhs.denominator);
    }

    public override string ToString()
    {
        return numerator.ToString() + "/" + denominator.ToString();
    }

}
