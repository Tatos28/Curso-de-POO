class Program
{
    static void Main()
    {
        int[] payment = { 100, 100, 200, 100 };
        int sum = 0;

        for (int i = 0; i < payment.Length; i++)
        {
            sum += payment[i];
        }

        int promedio = sum / payment.Length;

        Console.WriteLine($"El promedio de los sueldos es {promedio}");

        Console.WriteLine("\nSueldos que superan el promedio ");
        for (int i = 0; i < payment.Length; i++)
        {
            if (payment[i] > promedio)
            {
                Console.WriteLine(payment[i]);
            }
        }
    }
}