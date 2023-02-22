namespace VD911
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListBoxTest lbt = new ListBoxTest("Hello", "World");
            lbt.Add("What");
            lbt.Add("Is");
            lbt.Add("The");
            lbt.Add("C");
            lbt.Add("Sharp");
            string subst = "Universe";
            lbt[1] = subst;
            // truy cập tất cả các chuỗi
            int count = 1;
            foreach (string s in lbt)
            {
                Console.WriteLine($"Value {count}: {s}");
                count++;
            }
        }
    }
}