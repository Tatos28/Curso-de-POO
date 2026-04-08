namespace Arbol
    {
        public class Arbol
        {
            private int tamaño;
            private string follaje;

            public Arbol(int tamañoInicial)
            {
                tamaño = tamañoInicial;
                follaje = "nada";
            }

            public void SetFollaje(string nivel)
            {
                follaje = nivel;
                Console.WriteLine("Follaje actual: " + follaje);
            }

            public void Secar()
            {
                if (follaje == "mucho")
                {
                    follaje = "poco";
                }
                else if (follaje == "poco")
                {
                    follaje = "nada";
                }
                else
                {
                    Console.WriteLine("EL arbol ya no tiene hojas.");
                }

                Console.WriteLine("Follaje después de secarse: " + follaje);
            }

            public void Florecer()
            {
                tamaño += 10;
                Console.WriteLine("El árbol floreció");
                Console.WriteLine("Tamaño actual: " + tamaño);
            }
        }
    }
