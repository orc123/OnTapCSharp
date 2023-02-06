namespace VD503;
public class ListBox : Window
{
    private string listBoxContents;
    public ListBox(int top, int left, string listBoxContents) : base(top, left)
    {
        this.listBoxContents = listBoxContents;
    }

    public override void DrawWindow()
    {
        Console.WriteLine($"Writing string to the listbox: {listBoxContents}");
    }
}
