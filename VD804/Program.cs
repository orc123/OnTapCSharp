namespace VD804;

internal class Program
{
    static void Main(string[] args)
    {
        Document theNote = new Note("Test Note");
        IStorable isNote = theNote as IStorable;
        if(isNote != null)
        {
            isNote.Read();
            isNote.Write();
        }
        Console.WriteLine("\n");
        theNote.Read();
        theNote.Write();
        Console.WriteLine("\n");

        Note note2 = new Note("Second Note");
        IStorable isNote2 = note2 as IStorable;
        if (isNote != null)
        {
            isNote2.Read();
            isNote2.Write();
        }
        Console.WriteLine("\n");
        note2.Read();
        note2.Write();
        Console.WriteLine("\n");
    }
}