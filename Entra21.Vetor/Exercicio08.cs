using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criar um vetor para armazenar 10 números, solicite os números e armazene. Será aceito
//neste vetor somente números pares.

namespace Entra21.Vetor
{
    internal class Exercicio08
    {
        public void Executar()
        {
            var quantidade = 10;
            int[] numeros = new int[quantidade];
            for (int i = 0; i < numeros.Length; i++)
            {
                bool numeroValido = false;
                while (numeroValido == false)
                {
                    try
                    {
                        Console.Write("Digite um número par: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        numeros[i] = numero;
                        if ((numero % 2) == 0)
                        {
                            numeroValido = true;
                        }
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite um número que deve ser inteiro e par.");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                numeroValido = false;
            }

            Console.Write("Os números digitados foram: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + ",");
            }
        }
    }
}
