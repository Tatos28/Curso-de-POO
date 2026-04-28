using EjercicioParaExamen;
    
class Program
{
    static void Main(string[] args)
    {
        StandardShipment standard = new StandardShipment(1, 20);
        ExpressShipment express = new ExpressShipment(3, 15);

        Console.WriteLine("Costo Estandar: " + standard.CalculateCost());
        Console.WriteLine("Costo Express: " + express.CalculateCost());

        Console.WriteLine("\nCon impuesto 0.2:");
        Console.WriteLine("Costo Standard: " + standard.CalculateCost(0.2f));
        Console.WriteLine("Costo Express: " + express.CalculateCost(0.2f));

        express.PrioritizeShipment();
    }
}