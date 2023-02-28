namespace VD1102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Image theImage = new Image();

            ImageProcessor theProcessor = new ImageProcessor(theImage);
            theProcessor.AddToEffects(theProcessor.BlurEffect);
            theProcessor.AddToEffects(theProcessor.FilterEffect); 
            theProcessor.AddToEffects(theProcessor.RotateEffect);
            theProcessor.AddToEffects(theProcessor.SharpenEffect);
            theProcessor.ProcessImage();
        }
    }
}