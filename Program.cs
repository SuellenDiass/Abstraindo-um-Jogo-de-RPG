using System;
using Abstraindo_um_Jogo_de_RPG.src.Entities;

namespace Abstraindo_um_Jogo_de_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
           knight Sorscha = new knight("Sorscha", 2 , "Warrior");
           Wizard wizard = new Wizard("Naamah", 3,"Queen");

            Console.WriteLine(Sorscha.Attack(1));  // classe kinight calcula os bonus
            Console.WriteLine(Sorscha.Attack(7));
        }
    }
}
// encapsulamento consome informação simples e dentro dela há varias informações