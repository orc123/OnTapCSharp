namespace VD403
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            ThoiGian t = new ThoiGian(now);
            t.ThoiGianHienHanh();
        }
    }
}