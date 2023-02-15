namespace VD803;

internal class Program
{
    static void Main(string[] args)
    {
        Document document = new Document("Test Document");

        if (document is IStorable)
        {
            IStorable isDoc = (IStorable)document;
            isDoc.Read();
        }
        if (document is ICompressible)
        {
            ICompressible icDoc = (ICompressible)document;
            icDoc.Compress();
        }
    }
}