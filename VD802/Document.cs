namespace VD802;

public class Document : IStorableCompressible, IEncryptable
{
    private int status = 0;
    public Document(string s)
    {
        Console.WriteLine("Create document with: " + s);
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

    public void Compress()
    {
        Console.WriteLine("Implementing Compress");
    }

    public void Decompress()
    {
        Console.WriteLine("Implementing Decompress");
    }

    public void Decrypt()
    {
        Console.WriteLine("Implementing Decrypt");
    }

    public void Encrypt()
    {
        Console.WriteLine("Implementing Encrypt");
    }

    public void LogOriginalSize()
    {
        Console.WriteLine("Implementing LogOriginalSize");
    }

    public void LogSavedBytes()
    {
        Console.WriteLine("Implementing LogSavedBytes");
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
