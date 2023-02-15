namespace VD804;

public class Note : Document
{
    public Note(string s) : base(s)
    {
        Console.WriteLine("Creating note with: " + s);
    }
    public override void Read()
    {
        Console.WriteLine("Overriding the Read Method for Note!");
    }

    public void Write()
    {
        Console.WriteLine("Implementing the Write method for Note!");
    }
}
