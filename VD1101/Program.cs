namespace VD1101;

public class Program
{
    static void Main(string[] args)
    {
        Student thao = new Student("Thao");
        Student ba = new Student("Ba");
        Cat mun = new Cat(5);
        Cat ngao = new Cat(2);

        Pair studentPair = new Pair(thao, ba);
        Pair catPair = new Pair(mun, ngao);

        Console.WriteLine("Sinh vien \t\t\t: {0}", studentPair.ToString());
        Console.WriteLine("Meo \t\t\t: {0}", catPair.ToString());

        Pair.WhichIsFirst theStudentDelegate = new Pair.WhichIsFirst(Student.WhichStudentComesFirst);
        Pair.WhichIsFirst theCatDelegate = new Pair.WhichIsFirst(Cat.WhichCatComesFirst);

        studentPair.Sort(theStudentDelegate);
        Console.WriteLine("Sau khi sap xep studentPair\t\t:" + studentPair.ToString());
        studentPair.ReverseSort(theStudentDelegate);
        Console.WriteLine("Sau khi sap xep nguoc studentPair\t\t:" + studentPair.ToString());

        catPair.Sort(theCatDelegate);
        Console.WriteLine("Sau khi sap xep catPair\t\t:" + catPair.ToString());
        catPair.ReverseSort(theCatDelegate);
        Console.WriteLine("Sau khi sap xep nguoc catPair\t\t:" + catPair.ToString());
    }
}