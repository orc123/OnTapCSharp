namespace VD502
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Window win = new Window(1, 2);
            ListBox lb = new ListBox(3, 4, "Stand alone list box");
            Button b = new Button(5, 6);
            win.DrawWindow();
            lb.DrawWindow();
            b.DrawWindow();


            Window[] arr = new Window[3];
            arr[0] = new Window(1, 2);
            arr[1] = new ListBox(3, 4, "List box is array");
            arr[2] = new Button(5, 6);
            foreach (var item in arr)
            {
                item.DrawWindow();
            }
        }
    }
}