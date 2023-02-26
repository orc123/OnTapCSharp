using System.Text;
using System.Text.RegularExpressions;

namespace VD1005;

public class Program
{
    static void Main(string[] args)
    {
        string s1 = "Mot, hai, ba, Trung tam dao tao CNTT";

        Regex theRegex = new Regex(" |, ");

        StringBuilder stringBuilder = new StringBuilder();

        int id = 1;

        //foreach (string subString in theRegex.Split(s1)) VD10.5
        foreach (string subString in Regex.Split(s1, " |, "))
        {
            stringBuilder.Append($"{id++}: {subString} \n");
        }

        Console.WriteLine(stringBuilder);
    }
}