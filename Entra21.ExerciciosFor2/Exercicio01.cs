using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            for (var i = 0; i < 13; i++)
            {
                var nomePeca = "";
                var nomeValido = false;
                var precoPeca = 0.00;
                Console.WriteLine("Digite o nome da peça: ");
                nomePeca = Console.ReadLine();
                while (nomePeca.Trim().Length == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Digite um nome válido para a peça: ");
                    nomePeca = Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                while ((precoPeca <= 0.00))
                {
                    try
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Digite o preço da peça: R$");
                        precoPeca = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite um número válido para o preço da peça.");
                    }
                }
            }
        }
    }
}
