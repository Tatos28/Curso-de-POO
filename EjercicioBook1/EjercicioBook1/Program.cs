
using EjercicioBook1;

class Program
{
    static void Main(string[] args)
    {
        book book = new book(
            "Los 3 cerditos",
            "Paola Artmann",
            "libro.txt"
        );
        
        book.SaveToFile();

        Console.WriteLine("Contenido inicial del archivo:");
        book.PrintFileContent(); 
        book.AddParagraph("En un pueblito no muy lejano, vivía una mamá cerdita junto con sus tres cerditos");
        book.AddParagraph("Todos eran muy felices hasta que un día la mamá cerdita les dijo");
        book.AddParagraph("Hijitos, ustedes ya han crecido, es tiempo de que sean cerditos adultos y vivan por sí mismos");
        book.SaveToFile();
        Console.WriteLine("\nContenido después de escribir los 3 primeros parrafos");
        book.PrintFileContent();
    }
}