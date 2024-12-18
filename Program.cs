// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        //create refernce variable for list class and object of list class
        List<int> list = new List<int>() { 10, 20, 30 };
        
        Console.WriteLine("Using foreach");
        foreach(int item  in list)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("Using forloop");
        for(int i=0;i<list.Count;i++)
        {
            Console.WriteLine(list[i]);
        }


        //adding new elements
        list.Add(40);

        List<int> otherlist = new List<int>() { 50, 60, 70 };

        //adding new list to existing list
        list.AddRange(otherlist);

        foreach(int item in list)
        {
            Console.WriteLine(item);
        }

        //insert element at position 1
        list.Insert(1, 100);

        List<int> otherlist1 = new List<int>() { 200, 300, 400 };
        list.InsertRange(2, otherlist1);

        foreach (int item in list)
        {
            Console.WriteLine(item);
        }

        list.Remove(300);
        list.RemoveAt(0);
        list.RemoveRange(1,2);
        list.RemoveAll(n => n > 300);
        Console.WriteLine(list.IndexOf(200));
        Console.WriteLine("Binar search " + list.BinarySearch(40));
        Console.WriteLine(list.Contains(40));
        list.Sort();
        list.Reverse();

        Console.WriteLine("Final list is:");
        foreach (int item in list)
        {
            Console.WriteLine(item);
        }
        //using for each method instead of for loop
        list.ForEach(n=>Console.WriteLine(n));
        //
        List<string> strlist = new List<string>() { "Jaya", "Meera" };
        string[] strArr = strlist.ToArray();
        Console.WriteLine(list.Exists(n => n % 2 == 0));
        Console.WriteLine("First even number in list "+list.Find(n => n % 2 == 0));
        Console.WriteLine(list.FindIndex(n=>n% 2 == 0));
        Console.WriteLine("First even number in list " + list.FindLast(n => n % 2 == 0));
        Console.WriteLine(list.FindLastIndex(n => n % 2 == 0));
        Console.WriteLine(list.FindAll(n => n % 2 == 0));

        foreach (string str in strArr)
        {
            Console.WriteLine(str);
        }

        //convertAll
        List<int> intcollection = new List<int>() { 1,2,8,7};
        List<string> stringCollection = intcollection.ConvertAll<string>((n) =>
        {
            return Convert.ToString(n);
        });
        foreach(string str in stringCollection) 
        {
            Console.WriteLine(str);

        }
    }
}
