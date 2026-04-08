class Program
{
    static void Main(string[] args)
    {
        HauntedHouse house = new HauntedHouse("Peglet House", "Cholula, Condominio Mandala Edificio B" , 4);
        
        house.ShowInfo();

        Console.WriteLine();
        
        house.SpookVisitors();
    }
}