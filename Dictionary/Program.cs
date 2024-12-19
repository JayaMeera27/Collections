// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main()
    {
        Dictionary<int, string> employees = new Dictionary<int, string>()
        {
            {101,"xxxx"}, {102,"xxxxx"}, {103,"yyyyy"}
           
        
        };

        foreach(KeyValuePair<int,string> item in employees)
        {
            Console.WriteLine(item.Key+", "+item.Value);
        }

        //---------------------------------------Properties-----------------------------------------------

        //Count
        Console.WriteLine("\nCount of element in dictionary"+employees.Count);

        //get Value based on key
        Console.WriteLine("\nName of employee id 101 is " + employees[101]);

        //get all the keys
        Dictionary<int,string>.KeyCollection keys = employees.Keys;
        Console.WriteLine("\nKeys:");
        foreach(int item in keys)
        {
            Console.WriteLine(item);
        }

        //get all the values
        Dictionary<int,string>.ValueCollection values = employees.Values;
        Console.WriteLine("\nValues: ");
        foreach(string item in values)
        {
            Console.WriteLine(item);
        }

        //------------------------------------Methods-------------------------------------
        employees.Add(104, "xxxx");

        employees.Remove(103);

        bool a = employees.ContainsKey(101);
        Console.WriteLine("\n Contain key: " + a);

        Console.WriteLine("\nContains Value: " + employees.ContainsValue("xxxx"));

        //clear will remove all the elements in dictionary
        employees.Clear();
    }
}