namespace shape1;

public class Circle : Shape
{
    private int radius;

    public Circle(int radius)
    {
        this.radius = radius;
    }

    public override int CalculateArea()
    {
        return (int)(Math.PI * radius * radius);
    }
}