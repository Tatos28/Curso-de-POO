using Survivors;

class Program
{
    static void Main(string[] args)
    {
       
        Citizen citizen1 = new Citizen("Citizen Mike", 100);
        Citizen citizen2 = new Citizen("Citizen Walter", 100);
        Soldier soldier = new Soldier("Soldier Sumo", 110, 5);
        Engineer engineer = new Engineer("Engineer Big Foot", 120, "Wingman");

        Console.WriteLine("A horde is coming!\n");

        int totalDamage = 0;

       
        
        
        
        for (int turn = 1; turn <= 5; turn++)
        {
            Console.WriteLine($" TURN {turn} \n");

           
            Console.WriteLine("Citizen 1 is defending.");
            totalDamage += citizen1.Defend();
            Console.WriteLine();

         
            Console.WriteLine("Citizen 2 is defending.");
            totalDamage += citizen2.Defend();
            Console.WriteLine();

           
            Console.WriteLine("Soldier is defending.");
            totalDamage += soldier.Defend();
            soldier.Reload();
            Console.WriteLine();

            
            Console.WriteLine("Engineer is defending.");
            totalDamage += engineer.Defend();
            engineer.ResetTrap();
            Console.WriteLine();
        }

        Console.WriteLine($"The horde was defeated. The total damage inflicted was: {totalDamage}");
    }
}