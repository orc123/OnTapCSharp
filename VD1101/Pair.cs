namespace VD1101;

public class Pair
{
    private object[] thePair = new object[2];
    public delegate Comparison WhichIsFirst(object obj1, object obj2);

    public Pair(object firstObject, object secondObject)
    {
        thePair[0] = firstObject;
        thePair[1] = secondObject;
    }

    public void Sort(WhichIsFirst theDelegateFunc)
    {
        if (theDelegateFunc(thePair[0], thePair[1]) == Comparison.theSecondComesFirst)
        {
            object temp = thePair[0];
            thePair[0] = thePair[1];
            thePair[1] = temp;
        }
    }

    public void ReverseSort(WhichIsFirst theDelegateFunc)
    {
        if (theDelegateFunc(thePair[0], thePair[1]) == Comparison.theFirstComesFirst)
        {
            object temp = thePair[0];
            thePair[0] = thePair[1];
            thePair[1] = temp;
        }
    }

    public override string ToString()
    {
        return thePair[0].ToString() + ", " + thePair[1].ToString();
    }
}
