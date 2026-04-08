using System;

class Program
{
    static void Main(string[] args)
    {
        Arbol.Arbol arbol = new Arbol.Arbol(100);
        
        arbol.SetFollaje("mucho");

        arbol.Secar();
        arbol.Secar();
        arbol.Secar();
       
       

        arbol.Florecer();
    }
}
