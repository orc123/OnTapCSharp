namespace VD901;

public class Employee
{
    private int empId;
    private int size;
    public Employee(int empId)
    {
        this.empId = empId;
    }
    public override string ToString()
    {
        return empId.ToString();
    }
}
