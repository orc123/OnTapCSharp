namespace VD503;

public abstract class Window
{
    protected int top;
    protected int left;
    public Window(int top, int left)
    {
        this.top = top;
        this.left = left;
    }

    abstract public void DrawWindow();
}
