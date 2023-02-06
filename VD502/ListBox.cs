namespace VD502;

public class ListBox : Window
{
    private string listBoxContent;
    public ListBox(int top, int left, string listBoxContent) : base(top, left)
    {
        this.listBoxContent = listBoxContent;
    }
    public override void DrawWindow()
    {
        base.DrawWindow();
        Console.WriteLine($"Writing string to the listbox: {listBoxContent}");
    }

}
