using System.Collections;

class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public string Job { get; set; }

   
}

public enum SortBy

{
    EmpID,Name,Job
}

class EmployeeComparer : IComparer<Employee>
{
    public SortBy sortBy { get; set; }
    
    public int Compare(Employee x, Employee y)
    {
        //Sort by EmpID
        //public int Compare(Employee? x, Employee? y)
        //{
        //    return x.EmpId - y.EmpId;
        //}

        //sort by EmpName
        //public int Compare(Employee x, Employee y)
        //{
        //    return x.Name.CompareTo(y.Name);
        //}

        int result = 0;
        switch(this.sortBy)
        {
            case SortBy.EmpID:
                result = x.EmpId-y.EmpId;
                break;
            case SortBy.Name:
                result = (x.Name!=null) ? x.Name.CompareTo(y.Name) :0; break;
            case SortBy.Job:
                result = x.Job!=null ? x.Job.CompareTo(y.Job):0; break;
        }
        return result;
    }
   
}
class IComaprableEg
{
    public static void Main(string[] args)
    {

        List<Employee> list = new List<Employee>()
        {
            new Employee(){EmpId = 104,Name="meera",Job="zzzzzzzzz"},
            new Employee(){EmpId = 102,Name="jayameera",Job="zzzzzzzzz"},
            new Employee(){EmpId = 101,Name="jaya meera",Job="zzzzzzzzz"}

        };
        EmployeeComparer employeeComparer = new EmployeeComparer();
        employeeComparer.sortBy = SortBy.Name; ;
        list.Sort(employeeComparer);
        foreach (var item in list)
        {
            Console.WriteLine(item.EmpId + "," + item.Name + "," + item.Job);
        }
    }
}

