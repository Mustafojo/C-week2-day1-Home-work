
Person person = new Person();

person.Text = "Laykro faromush nakuned";

person.Likes = 463;

person.Commets = 32;

Console.Write("Text: ");
Console.WriteLine(person.GetInfo());
Console.Write("Likes: ");
Console.WriteLine(person.GetInfo2());
Console.Write("Comments: ");
Console.WriteLine(person.GetInfo3());
class Person
{
    public string Text;
    public int Likes;

    public int Commets;
    public string GetInfo()

    {
        return $"{Text} ";
    }
    public string GetInfo2()
    {
        return $"{Likes}";
    }
    public string GetInfo3()
    {
        return $"{Commets}";
    }







}




