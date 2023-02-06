namespace VD503;

public class Button : Window
{
    public Button(int top, int left) : base(top, left)
    {
    }

    public override void DrawWindow()
    {
        Console.WriteLine($"Drawing button at {top}, {left}");
    }
}
