namespace VD803;
public class Document : IStorable
{
    private int status = 0;
    public Document(string s)
    {
        Console.WriteLine($"Create document with: {s}");
    }
    public int Status
    {
        get
        {
            return status;
        }

        set
        {
            status = value;
        }
    }

    public void Read()
    {
        Console.WriteLine("Implement the Read Method for IStorable");
    }

    public void Write(object obj)
    {
        Console.WriteLine("Implement the Write Method for IStorable");
    }
}
