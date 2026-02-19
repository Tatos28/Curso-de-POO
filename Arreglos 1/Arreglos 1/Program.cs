class Program
{
    static void Main()
    {
        Console.Write("Enter number of employees: ");
        int n = int.Parse(Console.ReadLine());

        int[] salaries = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter salary: ");
            salaries[i] = int.Parse(Console.ReadLine());
            sum += salaries[i];
        }

        double average = (double)sum / n;

        Console.WriteLine("Average salary: " + average);
        Console.WriteLine("Salaries above average:");

        for (int i = 0; i < n; i++)
        {
            if (salaries[i] > average)
            {
                Console.WriteLine(salaries[i]);
            }
        }
    }
}