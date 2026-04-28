using Lab;
public class Band : Artist
{
    private int numOfMembers;

    public Band(string name, string country, string gender, int numOfMembers)
        : base(name, country, gender)
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
            return "Chico";
        else if (numOfMembers <= 6)
            return "Mediano";
        else
            return "Grandote";
    }
}


