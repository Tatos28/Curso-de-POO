using Herencia;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", 3);

       
        car.Accelerate(); 
        car.Accelerate(); 
        car.Accelerate(); 

       
        for (int i = 0; i < 3; i++)
        {
            if (car.Crash())
            {
                Console.WriteLine("El coche choco");
            }
        }

       
        car.OpenTrunk();
    }
}