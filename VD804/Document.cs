namespace VD804;

public class Document : IStorable
{
    public Document(string s)
    {
        Console.WriteLine("Creating document with: " + s);
    }
    public virtual void Read()
    {
        Console.WriteLine("Document Read Method for IStorable");
    }

    public void Write()
    {
        Console.WriteLine("Document Write Method for IStorable");
    }
}
