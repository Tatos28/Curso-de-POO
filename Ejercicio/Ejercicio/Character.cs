namespace Ejercicio;

public class Character
{
   
        protected string name;

        public Character(string name)
        {
            this.name = name;
        }

        public virtual void Introduce()
        {
           
            Console.WriteLine($"Hola, me llamo {name}");
            
    }
}