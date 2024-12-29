// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
public enum TypeOfCustomer
{

    RegularCustomer, VIPCustomer
}
public class Customer
{
    private string email;
    public string CustomerID { get; set; }
    public string CustomerName { get; set; }
    public string Email
    {
        get => email;
        set
        {
            if (value.Contains("@"))
            {
                email = value;
            }

        }

    }
    public TypeOfCustomer CustomerType { get; set; }
}

public class CustomerList :ICollection<Customer>
{
    private List<Customer> customers = new List<Customer>();

    public int Count => customers.Count;

    public bool IsReadOnly => false;

    public IEnumerator GetEnumerator()
    {
        //yield return customers[1];
        return customers.GetEnumerator();
    }

    public void Add(Customer cust)
    {
        customers.Add(cust);
    }

    IEnumerator<Customer> IEnumerable<Customer>.GetEnumerator()
    {
        return customers.GetEnumerator();
    }

    public void Clear()
    {
        customers.Clear();
    }

    public bool Contains(Customer item)
    {
        return customers.Contains(item);
    }

    public void CopyTo(Customer[] array, int arrayIndex)
    {
       customers.CopyTo(array, arrayIndex);
    }

    public bool Remove(Customer item)
    {
        return customers.Remove(item);
    }

    public Customer Find(Predicate<Customer> match)
    {
        return customers.Find(match);
    
    }
}
class Program3
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        CustomerList list = new CustomerList()
        {
            new Customer(){ CustomerID = "123", CustomerName="Meera", Email= "jayameera272@gmail.com" , CustomerType=TypeOfCustomer.VIPCustomer },
            new Customer(){CustomerID = "123", CustomerName="JayaMeera", Email= "jayameera272gmail.com" , CustomerType=TypeOfCustomer.VIPCustomer }

        };
        Customer new_cust = new Customer() { CustomerID = "123", CustomerName = "Meera", Email = "jayameera272@gmail.com", CustomerType = TypeOfCustomer.RegularCustomer };
        list.Add(new_cust);

        foreach (Customer cust in list)
        {
            Console.WriteLine(cust.CustomerID + " " + cust.CustomerName + " " + cust.Email + " " + cust.CustomerType);
        }

    }
}

