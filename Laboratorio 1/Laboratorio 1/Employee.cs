
namespace Laboratorio1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("¿Cuántos empleados desea ingresar? ");
        int n = int.Parse(Console.ReadLine());

        Employee[] employees = new Employee[n];

        float total = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEmpleado #{i + 1}");

            Console.Write("Nombre: ");
            string name = Console.ReadLine();

            Console.Write("Categoría: ");
            string category = Console.ReadLine();

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Salario: ");
            float salary = float.Parse(Console.ReadLine());

            employees[i] = new Employee(name, category, id, salary);

            total += salary;
        }

        if (n == 0)
        {
            Console.WriteLine("No se ingresaron empleados.");
            return;
        }

        float average = total / n;

        string nombres = "";

        for (int i = 0; i < n; i++)
        {
            if (employees[i].GetSalary() < average)
            {
                nombres += employees[i].name + ", ";
            }
        }

        if (nombres.Length > 0)
        {
            nombres = nombres.Substring(0, nombres.Length - 2);
        }
        else
        {
            nombres = "Ninguno";
        }

        Console.WriteLine($"\nEmpleados que ganan menos que el promedio que es ${average:F2}: {nombres}");
    }
}