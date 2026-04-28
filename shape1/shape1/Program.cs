using shape1;

class Program
{
    static void Main(string[] args)
    {
        Shape rect = new Rectangle(5, 10);
        Shape circle = new Circle(7);

        Console.WriteLine("Área del rectángulo: " + rect.CalculateArea());
        Console.WriteLine("Área del círculo: " + circle.CalculateArea());
    }
}