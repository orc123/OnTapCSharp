namespace VD909
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListBoxText lbt = new ListBoxText("Hello", "World");
            lbt.Add("Who");
            lbt.Add("is");
            lbt.Add("Ngoc");
            lbt.Add("Mun");

            string strTest = "Universe";
            lbt[1] = strTest;

            for (int i = 0; i < lbt.GetNumEntries(); i++)
            {
                Console.WriteLine($"lbl[{i}]: {lbt[i]}");
            }

        }
    }
}