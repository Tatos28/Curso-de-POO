using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (StreamWriter sw = new StreamWriter(@"C:\Tareas UDLAP\Proyectos programacion\textos\texto2.txt"))
        {
            sw.WriteLine("El nitrogeno presente en nuestro ADN,");
            sw.WriteLine("el calcio de nuestros dientes, el hierro de nuestra sangre,");
            sw.WriteLine("el carbono en las tartas de manzana...");
            sw.WriteLine("todos fueron creados en el interior de estrellas que chocaron entre si.");
            sw.WriteLine("Estamos hechos del material de las estrellas.");
            sw.WriteLine(" Carl Sagan.");
        }

        FileInfo archivo = new FileInfo(@"C:\Tareas UDLAP\Proyectos programacion\textos\texto2.txt");
        Console.WriteLine($"pesa: {archivo.Length} bytes");
    }
}