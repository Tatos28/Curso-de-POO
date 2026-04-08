namespace Profe;

public class Person
{
    protected string name;
    protected string gender;
    protected int age;

    public Person(string name, string gender, int age)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
    }

    public void Salute()
    {
        Console.WriteLine($"Hi, my name is {name}, I am {age} years old.");
    }
}