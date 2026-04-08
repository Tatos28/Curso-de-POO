namespace Dron;

public class Drone
{

    private int battery;
    private int height;
    private bool droneOn;

    public Drone()
    {
        battery = 100;
        height = 0;
        droneOn = true;
    }

    public void SetBattery(int value)
    {
        if (value > 100)
        {
            Console.WriteLine("La batería no puede ser mayor a 100");
            return;
        }

        battery = value;

        if (battery < 0)
        {
            Fall();
        }
    }

    public void SetHeight(int newHeight)
    {
        if (!droneOn)
        {
            Console.WriteLine("El dron está apagado");
            return;
        }

        if (newHeight < 0)
        {
            Console.WriteLine("La altura no puede ser negativa");
            return;
        }

        if (battery < 40)
        {
            Fall();
            return;
        }

        battery -= 40;
        height = newHeight;

        Console.WriteLine($"Altura: {height} mts | Batería: {battery}%");

        if (battery < 0)
        {
            Fall();
        }
    }

    public void Fall()
    {
        Console.WriteLine("El drone se ha caido");
        droneOn = false;
        height = 0;
    }

    public void ResetHeight()
    {
        height = 0;
    }
}
