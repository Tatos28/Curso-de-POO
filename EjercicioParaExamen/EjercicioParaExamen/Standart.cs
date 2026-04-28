namespace EjercicioParaExamen;

public class StandardShipment : Shipment
{
    private int daysInWarehouse;

    public StandardShipment(int weight, int distance) : base(weight, distance)
    {
        daysInWarehouse = 0;
    }

    public override float CalculateCost()
    {
        return weight * distance * 0.05f;
    }
    
    public float CalculateCost(float aduana)
    {
        return CalculateCost() * (1 + aduana);
    }

    public float CalculateWarehouseCost()
    {
        return daysInWarehouse * 10;
    }
}