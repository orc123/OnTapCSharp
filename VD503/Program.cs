namespace VD503;

public class Program
{
    static void Main(string[] args)
    {
        Window[] winArray = new Window[3];
        winArray[0] = new ListBox(1, 2, "First List Box");
        winArray[1] = new ListBox(3, 4, "Second List Box");
        winArray[2] = new Button(5, 6);

        foreach (var item in winArray)
        {
            item.DrawWindow();
        }
    }
}