namespace shape1;

public class Rectangle : Shape
{
    private int baseValue;
    private int height;

    public Rectangle(int baseValue, int height)
    {
        this.baseValue = baseValue;
        this.height = height;
    }

    public override int CalculateArea()
    {
        return baseValue * height;
    }
}