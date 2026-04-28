    namespace Lab;

    public class Artist
    {
        protected string name;
        protected string country;
        protected string gender;

        public Artist(string name, string country, string gender)
        {
            this.name = name;
            this.country = country;
            this.gender = gender;
        }
        public virtual void Perform()
        {
            Console.WriteLine($"El publico está que arde {name} está tocando de locos");
        }

        
        
        public virtual void Introduce()
        {
            Console.WriteLine($"Hola, somos {name} y venimos de {country}");
        }
    }