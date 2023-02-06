namespace VD501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Window w = new Window(5, 10);
            w.DrawWindow();

            ListBox lb = new ListBox(20, 10, "Hello World!");
            lb.DrawWindow();
        }
    }
}