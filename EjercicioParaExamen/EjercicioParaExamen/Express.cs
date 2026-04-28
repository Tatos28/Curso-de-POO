namespace EjercicioParaExamen;

using System;

public class ExpressShipment : Shipment
{
    public ExpressShipment(int weight, int distance) : base(weight, distance)
    {
    }

    public override float CalculateCost()
    {
        return weight * distance * 0.1f + 50;
    }
    
    
    
    public float CalculateCost(float aduana)
    {
        return CalculateCost() * (1 + aduana);
    }

    
    
    public void PrioritizeShipment()
    {
        Console.WriteLine("El envío ha sido priorizado.");
    }
}