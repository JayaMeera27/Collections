// See https://aka.ms/new-console-template for more information


using System;

class Employee:IComparable,IEquatable<Employee>
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public string Job { get; set; }

    public int CompareTo(Object other)
    
    {
        Console.WriteLine(this.EmpId + "," + ((Employee)other).EmpId);
        return this.EmpId - ((Employee)other).EmpId;
    }

    public bool Equals(Employee other)
    {
        return this.EmpId == other.EmpId && this.Name == other.Name && this.Job == other.Job;
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
        Employee new_employee = new Employee() { EmpId = 104, Name = "meera", Job = "zzzzzzzzz" };
        Console.WriteLine("It Contains:"+list.Contains(new_employee));
        list.Sort();
        foreach(var item in list)
        {
            Console.WriteLine(item.EmpId+","+item.Name+","+item.Job);
        }
    }
}
