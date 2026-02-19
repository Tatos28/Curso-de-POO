
namespace EjercicioDiagrama
{
public class Book
{
    private string title;
    private string author;
    private int pages;
    private bool open;
    
    private Book(string title, string author, int pages)
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
        this.open = false;
    }

    public void ShowInfo()
    {
        Console.WriteLine(title);
        Console.WriteLine(author);
        Console.WriteLine(pages);
        Console.WriteLine(open);
    }

    public void Open()
    {
        open = true;
        Console.WriteLine("Book Opened");
    }
    public void Close()
    {
        open = false;
        Console.WriteLine("Book Closed");
        }
}
}