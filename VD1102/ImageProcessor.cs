namespace VD1102;

public class ImageProcessor
{
    public delegate void DoEffect();

    private DoEffect[] arrayOfEffects;
    private Image image;
    private int numEffectsRegistered = 0;

    public ImageProcessor(Image image)
    {
        this.image = image;
        arrayOfEffects = new DoEffect[10];
    }

    public DoEffect BlurEffect = new DoEffect(Blur);
    public DoEffect SharpenEffect = new DoEffect(Sharpen);
    public DoEffect FilterEffect = new DoEffect(Filter);
    public DoEffect RotateEffect = new DoEffect(Rotate);

    public void AddToEffects(DoEffect theEffect)
    {
        if (numEffectsRegistered >= 10)
        {
            throw new Exception("Too many members in array");
        }
        arrayOfEffects[numEffectsRegistered ++] = theEffect;
    }

    public static void Blur()
    {
        Console.WriteLine("Blurring image");
    }
    public static void Filter()
    {
        Console.WriteLine("Filtering image");
    }
    public static void Sharpen()
    {
        Console.WriteLine("Sharpening image");
    }
    public static void Rotate()
    {
        Console.WriteLine("Rotating image");
    }

    public void ProcessImage()
    {
        for (int i = 0; i < numEffectsRegistered; i++)
        {
            arrayOfEffects[i]();
        }
    }
}
