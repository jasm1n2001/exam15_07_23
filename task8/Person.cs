public class Person
{
    public string LastName;
    public string FirstName;
    public int Age;


    public int GetInfo()
    {
        System.Console.WriteLine($"Hello! My name is{LastName} {FirstName}.");
        
     }
}