namespace Bandas;

public class Band : Artist
{
    private int numOfMembers;

    public Band(string name, string country, string genre, int numOfMembers)
        : base(name, country, genre)
    {
        this.numOfMembers = numOfMembers;
    }

    public bool PlayEncore()
    {
        Random rnd = new Random();
        return rnd.Next(0, 2) == 1;
    }

    public string GetStageSize()
    {
        if (numOfMembers <= 3)
            return "Small";
        else if (numOfMembers <= 6)
            return "Medium";
        else
            return "Large";
    }
}