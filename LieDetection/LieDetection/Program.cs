using LieDetection;

class Program
{
    static void Main(string[] args)
    {
        LieDetector detector = new LieDetector("Eduardo");
        
        detector.AnalyzeAnswer("Yo no me comi tu hamburguesa");
        
        detector.ShowReport();
        
        if (detector.IsLier())
        {
            Console.WriteLine("Proceder con cautela ");
        }
    }
}

