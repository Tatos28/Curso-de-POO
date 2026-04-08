using Profe;  

namespace Profe;

public class Professor : Person
{
    private string department;
    private float salary;

    public Professor(string name, string gender, int age,
        string department, float salary)
        : base(name, gender, age)
    {
        this.department = department;
        this.salary = salary;
    }

    public void Teach()
    {
        Console.WriteLine($"Soy {name} y estoy dando clases en {department}");
    }
}