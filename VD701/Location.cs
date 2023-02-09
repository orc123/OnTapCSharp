namespace VD701;

public struct Location
{
    private int xVal;
    private int yVal;
    public Location(int xCoordinate, int yCoordinate)
	{
        xVal = xCoordinate;
        yVal = yCoordinate;
	}

    public int X
    {
        get
        {
            return xVal;
        }
        set
        {
            xVal = value;
        }
    }

    public int Y
    {
        get
        {
            return yVal;
        }
        set
        {
            yVal = value;
        }
    }

    public override string ToString()
    {
        return (String.Format("{0}, {1}", xVal, yVal));
    }
}

