namespace VD305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Nhiet do dong: {(int)EnumNhietDoNuoc.DoDong}");
            Console.WriteLine($"Nhiet do nguoi: {(int)EnumNhietDoNuoc.DoNguoi}");
            Console.WriteLine($"Nhiet do am: {(int)EnumNhietDoNuoc.DoAm}");
            Console.WriteLine($"Nhiet do nong: {(int)EnumNhietDoNuoc.DoNong}");
            Console.WriteLine($"Nhiet do soi: {(int)EnumNhietDoNuoc.DoSoi}");
        }
    }
}