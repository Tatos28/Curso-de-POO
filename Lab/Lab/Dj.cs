namespace Lab;
public class DJ : Artist
{
    private string software;

    public DJ(string name, string country, string gender, string software)
        : base(name, country, gender)
    {
        this.software = software;
    }

    public int MixTrack()
    {
        Random rnd = new Random();
        return rnd.Next(180, 301); 
    }
    public int GetEnergyLevel()
    {
        Random rnd = new Random();
        return rnd.Next(1, 3); 
    }
    
}