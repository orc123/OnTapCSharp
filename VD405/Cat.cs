namespace VD405;

public class Cat
{
    private static int instance = 0;
	public Cat()
	{
		instance++;
	}

	public static void HowManyCat()
	{
		Console.WriteLine($"{instance} cats");
	}
}
