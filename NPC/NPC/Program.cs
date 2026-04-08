using System;
using NPC;

class Program
{
    static void Main(string[] args)
    {
        Personaje npc = new Personaje("Juan");

        npc.React("Hola viajero");

        npc.React("Todo está bien", 1);
        npc.React("Necesito hablar contigo", 2);
        npc.React("¡Déjame en paz!", 3);

        npc.React("Qué bueno verte", true);
        npc.React("¿Qué quieres?", false);
    }
}