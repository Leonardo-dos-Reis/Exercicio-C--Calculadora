using System;

namespace CalculadoraCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja realizar?");
            Console.WriteLine("");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair do programa");
            Console.WriteLine("");
            Console.WriteLine("---------------");
            Console.WriteLine("");
            Console.WriteLine("Escolha uma das opções acima : ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
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

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("--- SUBTRACAO ---");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite o segundo valor : ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 - v2;
            Console.Clear();
            
            Console.WriteLine($"O resultado da subtracao dos valores é : {resultado}");

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("--- MULTIPLICACAO ---");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite o segundo valor : ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 * v2;
            Console.Clear();
            
            Console.WriteLine($"O resultado da multiplicacao dos valores é : {resultado}");

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("--- DIVISAO ---");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite o segundo valor : ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 / v2;
            Console.Clear();
            
            Console.WriteLine($"O resultado da divisao dos valores é : {resultado}");

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu();
        }
    }
}