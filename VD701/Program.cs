namespace VD701;

public class Program
{
    public static void Main(string[] args)
    {
        Location loc1 = new Location(200, 300);
        Console.WriteLine("Loc1 location: {0}", loc1);

        Program program = new Program();
        program.myFunc(loc1);
        Console.WriteLine("Loc1 location: {0}", loc1);
    }

    public void myFunc(Location location)
    {
        location.X = 50;
        location.Y = 100;
        Console.WriteLine("Loc1 location: {0}", location);
    }
}