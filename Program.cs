using System;

namespace Ola_Usuario
{
    class Program
    {
        static void Main(string[] args)

        {   string nome;
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"Olá {nome}");
        }
    }
}
