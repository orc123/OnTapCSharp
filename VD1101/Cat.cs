namespace VD1101;

public class Cat
{
    private int weight;
    public Cat(int weight)
    {
        this.weight = weight;
    }

    public static Comparison WhichCatComesFirst(Object o1, Object o2)
    {
        Cat c1 = (Cat)o1;
        Cat c2 = (Cat)o2;
        return c1.weight > c2.weight ? 
            Comparison.theSecondComesFirst : 
            Comparison.theFirstComesFirst;
    }

    public override string ToString()
    {
        return weight.ToString();
    }
}
