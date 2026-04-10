namespace Bandas;

public class Artist
{
    protected string name;
    protected string country;
    protected string genre;

    public Artist(string name, string country, string genre)
    {
        this.name = name;
        this.country = country;
        this.genre = genre;
    }
    public virtual void Perform()
    {
        Console.WriteLine($"The public is going wild. {name} is playing awesome!");
    }

    public virtual void Introduce()
    {
        Console.WriteLine($"Hi, we are {name} from {country}");
    }
}