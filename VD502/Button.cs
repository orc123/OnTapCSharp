namespace VD502;

public class Button : Window
{
    public Button(int top, int left) : base(top, left)
    {
    }
    public override void DrawWindow()
    {
        Console.WriteLine($"Drawing a button at {top}, {left}");
    }
}
