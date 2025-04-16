using System;

namespace CalculadoraCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Soma();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja realizar?");
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("--- SOMA ---");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite o segundo valor : ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 + v2;
            Console.Clear();
            
            Console.WriteLine($"O resultado da soma dos valores é : {resultado}");
        }
    }
}