namespace LieDetection;

public class LieDetector
{

    private string suspectName;
    private string question;
    private int suspicionLevel;
    private int minSuspicion;
    private int maxSuspicion;

    Random random = new Random();
    
    public LieDetector(string suspectName)
    {
        this.suspectName = suspectName;
        minSuspicion = 1;
        maxSuspicion = 5;
    }
    
    //Metodo 1
    public void AnalyzeAnswer(string answer)
    {
        Console.WriteLine("Analizando respuesta...");

        question = answer;

        suspicionLevel = random.Next(minSuspicion, maxSuspicion + 1);
    }

    // Metodo 2
    public void ShowReport()
    {
        Console.WriteLine("Sospechoso: " + suspectName);
        Console.WriteLine("Respuesta analizada: " + question);
        Console.WriteLine("Nivel de sospecha: " + suspicionLevel);
    }

    // Metodo 3
    public bool IsLier()
    {
        if (suspicionLevel >= 4)
        {
            return true;
        }

        return false;
    }
}