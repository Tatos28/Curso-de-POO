namespace EjercicioParaExamen;

public class Shipment
{
    protected int weight;
    protected int distance;

    public Shipment(int weight, int distance)
    {
        this.weight = weight;
        this.distance = distance;
    }

    public virtual float CalculateCost()
    {
        return 0;
    }
}