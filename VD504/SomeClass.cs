namespace VD504;

public class SomeClass
{
    private int _value;
	public SomeClass(int val)
	{
		_value = val;
	}

    public virtual string ToString()
    {
        return _value.ToString();
    }
}
