namespace VD404
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            ThoiGian t1 = new ThoiGian(currentTime);
            t1.ThoiGianHienHanh();

            ThoiGian t2 = new ThoiGian(2021, 11, 19, 21, 10);
            t2.ThoiGianHienHanh();
        }
    }
}