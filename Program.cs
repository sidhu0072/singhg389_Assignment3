public class BaseClass
{
    public virtual bool IsValidated()
    {
        return false;
    }
}

public class Person : BaseClass
{
    private string _firstName;
    private string _lastName;

    public Person(string firstName = "", string lastName = "")
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value ?? ""; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value ?? ""; }
    }

    public override bool IsValidated()
    {
        if (FirstName.Length > 0 && LastName.Length > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        Person person1 = new Person();
        Console.WriteLine(person1.IsValidated());

        Person person2 = new Person("Gurvinder", "Singh");
        Console.WriteLine(person2.IsValidated());

    }
}