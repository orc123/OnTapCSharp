namespace VD501;

public class ListBox : Window
{
    private string mListBoxContents;
    public ListBox(int top, int left, string theContent) : base(top, left)
    {
        this.mListBoxContents = theContent;
    }
    public new void DrawWindow()
    {
        base.DrawWindow();
        Console.Write($"ListBox write: {mListBoxContents}");
    }
}
