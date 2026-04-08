namespace Herencia;

public class Vehicle
    {
        protected string brand;
        protected int speed;

        public Vehicle(string brand)
        {
            this.brand = brand;
            this.speed = 0;
        }

        public virtual void Accelerate()
        {
            speed += 40;
            Console.WriteLine($"Accelerate {speed}");
        }

        public void Break()
        {
            speed = 0;
        }

        public bool Crash()
        {
            if (speed > 100)
            {
                Random rnd = new Random();
                int randNum = rnd.Next(0, 2); // 0 o 1
                return randNum == 1;
            }
            return false;
        }
    }
