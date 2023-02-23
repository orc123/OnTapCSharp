using System.Collections;

namespace VD914;

public class Program
{
    static void Main(string[] args)
    {
        ArrayList empArray = new ArrayList();
        Random random= new Random();
        for (int i = 0; i < 5; i++)
        {
            empArray.Add(new Employee(random.Next(10) + 100, random.Next(20)));
        }
        for (int i = 0; i < empArray.Count; i++)
        {
            Console.Write($"\n{empArray[i].ToString()}");
        }
        Console.WriteLine("\n");
        Employee.EmployeeComparer c = new Employee.EmployeeComparer();
        c.WhichComparision = Employee.EmployeeComparer.ComparisionType.EmpId;
        empArray.Sort(c);
        for (int i = 0; i < empArray.Count; i++)
        {
            Console.Write($"\n{empArray[i].ToString()}");
        }
        Console.WriteLine("\n");
        c.WhichComparision = Employee.EmployeeComparer.ComparisionType.Years;
        empArray.Sort(c);
        for (int i = 0; i < empArray.Count; i++)
        {
            Console.Write($"\n{empArray[i].ToString()}");
        }
        Console.WriteLine("\n");

    }
}