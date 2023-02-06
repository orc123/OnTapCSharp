namespace VD501;

public class Window
{
    private int top;
    private int left;
    public Window(int top, int left)
    {
        this.top = top;
        this.left = left;
    }
    public void DrawWindow()
    {
        Console.WriteLine($"Drawing Window at {top}, {left}");
    }
    
}
