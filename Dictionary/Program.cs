// See https://aka.ms/new-console-template for more information
using System.Collections;

class Program
{
    public static void Main()
    {
        //--------------------------------------------------List-------------------------------------------------

        //create refernce variable for list class and object of list class
        List<int> list = new List<int>() { 10, 20, 30 };

        Console.WriteLine("Using foreach");
        foreach (int item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Using forloop");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }


        //adding new elements
        list.Add(40);

        List<int> otherlist = new List<int>() { 50, 60, 70 };

        //adding new list to existing list
        list.AddRange(otherlist);

        foreach (int item in list)
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
        list.RemoveRange(1, 2);
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
        list.ForEach(n => Console.WriteLine(n));
        //
        List<string> strlist = new List<string>() { "Jaya", "Meera" };
        string[] strArr = strlist.ToArray();
        Console.WriteLine(list.Exists(n => n % 2 == 0));
        Console.WriteLine("First even number in list " + list.Find(n => n % 2 == 0));
        Console.WriteLine(list.FindIndex(n => n % 2 == 0));
        Console.WriteLine("First even number in list " + list.FindLast(n => n % 2 == 0));
        Console.WriteLine(list.FindLastIndex(n => n % 2 == 0));
        Console.WriteLine(list.FindAll(n => n % 2 == 0));

        foreach (string str in strArr)
        {
            Console.WriteLine(str);
        }

        //convertAll
        List<int> intcollection = new List<int>() { 1, 2, 8, 7 };
        List<string> stringCollection = intcollection.ConvertAll<string>((n) =>
        {
            return Convert.ToString(n);
        });
        foreach (string str in stringCollection)
        {
            Console.WriteLine(str);

        }

        //-------------------------------------------------------------------Dictionary-------------------------------------------------------------

        Dictionary<int, string> employees = new Dictionary<int, string>()
        {
            {101,"xxxx"}, {102,"xxxxx"}, {103,"yyyyy"}
           
        
        };

        foreach(KeyValuePair<int,string> item in employees)
        {
            Console.WriteLine(item.Key+", "+item.Value);
        }

        //--------------------------------------------------------------------Properties-----------------------------------------------

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

        //----------------------------------------------------------Methods-------------------------------------
        employees.Add(104, "xxxx");

        employees.Remove(103);

        bool a = employees.ContainsKey(101);
        Console.WriteLine("\n Contain key: " + a);

        Console.WriteLine("\nContains Value: " + employees.ContainsValue("xxxx"));

        //clear will remove all the elements in dictionary
        employees.Clear();

        //------------------------------------------------------SortedList-------------------------------------------

        SortedList<int, string> sortedlist = new SortedList<int, string>()
        {
            {103,"xxx" },
            {104,"yyyy" },
            {101,"Jaya" },
            {102,"Meera" }

        };

        foreach (KeyValuePair<int, string> kvp in sortedlist)
        {
            Console.WriteLine(kvp.Key + " " + kvp.Value);
        }

        //---------------------------------------------------HashTable----------------------------------------------------

        Hashtable hashtable = new Hashtable()
        {
            {103,"xxx" },
            {104,"yyyy" },
            {101,"Jaya" },
            {102,"Meera" },
            {"hello",23.45 }
        };

        if (hashtable[102] is string )
        {
            string value = Convert.ToString(hashtable[102]);
            Console.WriteLine(value);
        }
        //------------------------------------------HashSet---------------------------------------------
        HashSet<string> messages = new HashSet<string>()
        {
            "Good Morning","How are you","Have a good day"
        };

        foreach(var item in messages)
        {
            Console.WriteLine(item);
        }


        //Add
        messages.Add("Hello");

        //Remove
        messages.Remove("zzzzzzzzz");
        messages.RemoveWhere(m => m.EndsWith("you"));

        //Search
        messages.Contains("Good Morning"); //based on the serach value index will be recalculated, so it is faster

        HashSet<string> employees2024 = new HashSet<string>() { "Jaya","Meera","Priya","Mani"};
        HashSet<string> employees2025 = new HashSet<string>() { "Ram", "Sita" ,"Jaya"};

        employees2024.UnionWith(employees2025);

        foreach (var item in employees2024)
        {
            Console.WriteLine(item);
        }

        employees2024.IntersectWith(employees2025);

        foreach(var item in employees2024)
        {
            Console.Write(item);
        }

        //-------------------------------------------------------------IEnumerable-------------------------------------
        Console.WriteLine("\nIEnumerable");
        IEnumerable<string> messages1;
        messages1 = new List<string>()
        {
            "How are you","Have a great day","Great day"

        };
        foreach(string  item in messages1)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Iterator Method");
        Sample s = new Sample();       
        var enumerable = s.Method(); // here method will not be executed. If we call MoveNext(0 the execution of method starts.
        var enumerator = enumerable.GetEnumerator();
        enumerator.MoveNext(); //method will start execution. it return bool value if the value is found. prints "Iterator method executes"
        Console.WriteLine(enumerator.Current); // return 10. Current property will always represents the most recently returned value.
        enumerator.MoveNext();//prints "Iterator method executes continued"
        Console.WriteLine(enumerator.Current);//return 20;
        Console.WriteLine("\n");
        
        //instead of above we can use foreach
        foreach(var item in enumerable)
        {
            Console.WriteLine(item);
        }


        


    }
}

class Sample
{
    List<double> Prices { get; set; } = new List<double>() { 40, 30, 25, 50 };
    public IEnumerable<double> Method()
    {
        
        Console.WriteLine("Iterator method executes");
        yield return 10;
        Console.WriteLine("Iterator method executes continued");
        yield return 20;

        double sum = 0;

        sum += Prices[0];
        yield return sum;
        sum += Prices[1];
        yield return sum;

        Console.WriteLine("\n instead of above we can use foreach");
        foreach(var item in Prices)
        {
            sum+= item;
            yield return item;
        }
    }
}

