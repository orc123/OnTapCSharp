namespace VD502;

public class Window
{
	protected int top;
	protected int left;
	public Window(int top, int left)
	{
		this.top = top;
		this.left = left;
	}

	public virtual void DrawWindow()
	{
		Console.WriteLine($"Window: drawing window at {top}, {left}");
	}
}
