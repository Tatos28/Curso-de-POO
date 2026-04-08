using Pizzeria;

class Program
{
    static void Main(string[] args)
    {
        Pizza pizzaloca = new Pizza();

        Console.WriteLine("Solo piden pizza: ");
        pizzaloca.OrderPizza();

        Console.WriteLine("\nPiden pizza con true en extra queso: ");
        pizzaloca.OrderPizza(true);

        Console.WriteLine("\nPiden pizza con false en extra queso: ");
        pizzaloca.OrderPizza(false);

        Console.WriteLine("\nPiden una pizza con ingredientes que sí existen: ");
        pizzaloca.OrderPizza(new string[] { "Cheese", "Ham" });

        Console.WriteLine("\nPiden una pizza con un ingrediente que no existe:");
        pizzaloca.OrderPizza(new string[] { "Jam" });
    }
}