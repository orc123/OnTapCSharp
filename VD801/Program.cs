namespace VD801;

public class Program
{
    static void Main(string[] args)
    {
        Document doc = new Document("Test Document");
        doc.Status = -1;
        doc.Read();
        Console.WriteLine($"Document Status: {doc.Status}");

        IStorable isDoc = (IStorable)doc;
        isDoc.Status = 0;
        isDoc.Read();
        Console.WriteLine($"IStorable Status: {isDoc.Status}");
    }
}