using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase para o cebolinha");
            String frase = Console.ReadLine();
            frase = frase.Replace("r","l").Replace("R","L");
            Console.WriteLine(frase);
            Console.WriteLine($"Você escreveu uma frase e o cebolinha repetiu como {frase}");
            Console.ReadLine();
        }
    }
}
