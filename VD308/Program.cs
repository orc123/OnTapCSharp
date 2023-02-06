namespace VD308;

internal class Program
{
    static void Main(string[] args)
    {
        int tuoi;
        bool coGiaDinh; // 0: chưa có gia đình, 1: đã có gia đình
        bool gioiTinh;  // 0: giới tính nữ, 1: giới tính nam
        tuoi = 24;
        coGiaDinh= false;
        gioiTinh= true;

        if (tuoi >= 19)
        {
            if (!coGiaDinh)
            {
                if (!gioiTinh)
                    Console.WriteLine("Nu co the ket hon");
                else
                    if (tuoi > 19)
                    Console.WriteLine("Nam co the ket hon");
            }
        }
        else
        {
            Console.WriteLine("Khong du tuoi ket hon");
        }
    }
}