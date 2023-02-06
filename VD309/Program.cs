namespace VD309
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int mauDo = 0;
            const int mauCam = 1;
            const int mauVang = 2;
            const int mauLuc = 3;
            const int mauLam = 4;
            const int mauCham = 5;
            const int mauTim = 6;
            int chonMau = mauLuc;

            switch(chonMau)
            {
                case mauDo:
                    Console.WriteLine("Ban chon mau do");
                    break;
                case mauCam:
                    Console.WriteLine("Ban chon mau cam");
                    break;
                case mauVang:
                    //Console.WriteLine("Ban chon mau vang");
                case mauLuc:
                    Console.WriteLine("Ban chon mau luc");
                    break;
                case mauLam:
                    Console.WriteLine("Ban chon mau do");
                    goto case mauCham;
                case mauCham:
                    Console.WriteLine("Ban chon mau chau");
                    goto case mauTim;
                case mauTim:
                    Console.WriteLine("Ban chon mau tim");
                    goto case mauLuc;
                default:
                    Console.WriteLine("Ban khong chon mau nao");
                    break;
            }
            Console.WriteLine("Xin cam on!");

        }
    }
}