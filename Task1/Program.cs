


Person person = new Person();

person.FirstName = "Mustafo";

person.LastName = "Barotov";

person.AGE = 16;

Console.Write("FirstName: ");
Console.WriteLine(person.GetInfo());
Console.Write("Lastname: ");
Console.WriteLine(person.GetInfo2());
Console.Write("AGE: ");
Console.WriteLine(person.GetInfo3());
public class Person
{
    public string FirstName;
    public string LastName;

    public int AGE;
    public string GetInfo()

    {
        return $"{FirstName} ";
    }
    public string GetInfo2()
    {
        return $"{LastName}";
    }
    public string GetInfo3()
    {
        return $"{AGE}";
    }

}












