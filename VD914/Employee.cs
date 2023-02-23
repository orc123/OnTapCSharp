using System.Collections;

namespace VD914;

public class Employee : IComparable
{
    private int empId;
    private int yearsOfSrc = 1;
    public Employee(int empId)
    {
        this.empId = empId;
    }
    public Employee(int empId, int yearsOfSrc)
    {
        this.empId = empId;
        this.yearsOfSrc = yearsOfSrc;
    }

    public override string ToString()
    {
        return $"Id: {empId.ToString()}. Years of Svc: {yearsOfSrc.ToString()}";
    }

    public static EmployeeComparer GetComparer()
    {
        return new Employee.EmployeeComparer();
    }

    public int CompareTo(object obj)
    {
        Employee r = (Employee)obj;
        return this.empId.CompareTo(r.empId);
    }

    public int CompareTo(Employee rhs, EmployeeComparer.ComparisionType which)
    {
        switch (which)
        {
            case Employee.EmployeeComparer.ComparisionType.EmpId:
                return this.empId.CompareTo(rhs.empId);
            case Employee.EmployeeComparer.ComparisionType.Years:
                return this.empId.CompareTo(rhs.yearsOfSrc);
        }
        return 0;
    }
    public class EmployeeComparer : IComparer
    {
        private EmployeeComparer.ComparisionType whichComparision;
        public EmployeeComparer.ComparisionType WhichComparision
        {
            get { return whichComparision; }
            set { whichComparision = value; }
        }
        public enum ComparisionType
        {
            EmpId,
            Years
        }
        public int Compare(object lhs, object rhs)
        {
            Employee l = (Employee)lhs;
            Employee r = (Employee)rhs;
            return l.CompareTo(r, WhichComparision);
        }
    }


}
