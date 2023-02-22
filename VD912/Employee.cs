namespace VD912;

public class Employee
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
