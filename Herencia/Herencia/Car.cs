namespace Herencia;

public class Car : Vehicle
    {
        private int doorsNum;

        public Car(string brand, int doorsNum) : base(brand)
        {
            this.doorsNum = doorsNum;
        }

        public void OpenTrunk()
        {
            if (doorsNum % 2 != 0)
            {
                Console.WriteLine("Se abrio la cajuela");
            }
            else
            {
                Console.WriteLine("El coche no tiene cajuela");
            }
        }
    }
