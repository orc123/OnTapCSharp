namespace VD1003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Mot, hai, ba Trung Tam Dao Tao CNTT";

            const char Space = ' ';
            const char Comma = ',';

            char[] delimiters = new char[] { Space, Comma };

            string output = "";

            int ctr = 1;

            foreach (string subString in s1.Split(delimiters))
            {
                output += ctr++;
                output += ": ";
                output += subString;
                output += "\n";
            }
            Console.WriteLine(output);
        }
    }
}