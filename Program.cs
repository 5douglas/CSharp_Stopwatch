using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo (ex: 10s = 10 segundos)");
            Console.WriteLine("M = Minuto (ex: 10m = 10 minutos)");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); // deixar todos os carecteres minusculos
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // pega o ultimo caracter que o usuario inseriu 
            int time = int.Parse(data.Substring(0, data.Length - 1)); // pega todos os caracters MENOS o ultimo que o usuario inseriou
            int multiplier = 1;

            if( type == 'm')
            {
                multiplier = 60; // altera o valor de multiplicador caso o usuario escolha minutos
            }
            else if (time == 0)
            {
                System.Environment.Exit(0);
            }
            
            PreStart(time * multiplier); //converte o tempo que o usario inseriou em segundos, pois a aplicação está com o parametro em segundos
        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }
        static void Start(int time)
        {                   
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine($"{currentTime}");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);
            Menu();

        }

    }
}
