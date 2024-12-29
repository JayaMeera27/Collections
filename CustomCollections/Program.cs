// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Reflection.Metadata.Ecma335;



public enum TypeOfCustomer{

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

public class CustomerList: IEnumerable
{
    private List<Customer> customers = new List<Customer>();
    public IEnumerator GetEnumerator()
    {
        //yield return customers[1];
        return customers.GetEnumerator();
    }

    public void Add(Customer cust)
    {
        customers.Add(cust);
    }

  
}
class Program1
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

        foreach(Customer cust in list)
        {
            Console.WriteLine(cust.CustomerID+" "+cust.CustomerName+" "+cust.Email+" "+cust.CustomerType);
        }

    }
}