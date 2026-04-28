using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string ruta = @"C:\Tareas UDLAP\Proyectos programacion\textos\texto1.txt";
        
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Esto es");
            sw.WriteLine(" un hola mundo.");
        }
        
        using (StreamReader sr = new StreamReader(ruta))
        {
            string linea;
            while ((linea = sr.ReadLine()) != null)
            {
                Console.WriteLine(linea);
            }
        }
    }
}