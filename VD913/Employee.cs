namespace VD913;

public class Employee : IComparable
{
    private int empId;
    public Employee(int empId)
    {
        this.empId = empId;
    }

    public override string ToString()
    {
        return this.empId.ToString();
    }

    public int CompareTo(object? obj)
    {
        Employee r = (Employee)obj;
        return this.empId.CompareTo(r?.empId);
    }

    public int EmpId
    {
        get
        {
            return empId;
        }
        set
        {
            empId = value;
        }
    }
}
