namespace Laboratorio1;

public class Employee
{
    public string name;
    public string category;
    public int id;
    public float salary;

    public Employee(string name, string category, int id, float salary)
    {
        this.name = name;
        this.category = category;
        this.id = id;
        this.salary = salary;
    }

    public float GetSalary()
    {
        return salary;
    }
}