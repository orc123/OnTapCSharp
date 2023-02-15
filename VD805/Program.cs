using static System.Net.Mime.MediaTypeNames;

namespace VD805;

public class Program
{
    static void Main(string[] args)
    {
        // tạo đối tượng Document
        Document theDoc = new Document("Test Document");
        IStorable isDoc = theDoc as IStorable;
        if (isDoc != null)
        {
            isDoc.Read();
        }
        ITalk itDoc = theDoc as ITalk;
        if (itDoc != null)
        {
            itDoc.Read();
        }
        theDoc.Read();
        theDoc.Talk();
    }
}

interface IStorable
{
    void Read();
    void Write();
}

interface ITalk
{
    void Talk();
    void Read();
}

public class Document : IStorable, ITalk
{
    public Document(string s)
    {
        Console.WriteLine("Creating document with: " + s);
    }
    public virtual void Read()
    {
        Console.WriteLine("Implementing IStorable.Read");
    }

    public void Write()
    {
        Console.WriteLine("Implementing IStorable.Write");
    }

    void ITalk.Read()
    {
        Console.WriteLine("Implementing ITalk.Read");
    }
    public void Talk()
    {
        Console.WriteLine("Implementing ITalk.Talk");
    }
}