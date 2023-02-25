using System.Text;

namespace VD1004;

internal class Program
{
    static void Main(string[] args)
    {
        string s1 = "Mot, hai, ba Trung Tam Dao Tao CNTT";

        const char Space = ' ';
        const char Comma = ',';

        char[] delimiters = new char[] { Space, Comma };

        StringBuilder output = new StringBuilder();

        int ctr = 1;

        foreach (string subString in s1.Split(delimiters))
        {
            output.AppendFormat($"{ctr++}: {subString} \n");
        }

        Console.WriteLine(output);
    }
}