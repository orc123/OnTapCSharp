namespace VD1002;

public class Program
{
    static void Main(string[] args)
    {
        string s1 = "Mot hai ba bon";

        int ix;

        ix = s1.LastIndexOf(" ");

        string s2 = s1.Substring(ix + 1);

        s1 = s1.Substring(0, ix);

        ix = s1.LastIndexOf(" ");

        string s3 = s1.Substring(ix + 1);

        s1 = s1.Substring(0, ix);

        ix = s1.LastIndexOf(" ");

        string s4 = s1.Substring(ix + 1);

        s1 = s1.Substring(0, ix);

        ix = s1.LastIndexOf(" ");

        string s5 = s1.Substring(ix + 1);

        Console.WriteLine($"s2: {s2}\ns3: {s3}");

        Console.WriteLine($"s4: {s4}\ns5: {s5}");

        Console.WriteLine($"s1: {s1}\n");
    }
}