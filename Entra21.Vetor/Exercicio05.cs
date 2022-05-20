using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Solicite para o usuário 5 pesos e apresente a soma total dos pesos e a média
//dos pesos.

namespace Entra21.Vetor
{
    internal class Exercicio05
    {
        public void Executar()
        {
            int quantidade = 5;
            double[] pesos = new double[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o peso{i+1}: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                pesos[i] = peso;
            }
            double soma = 0.00;
            for (int i = 0; i < quantidade; i++)
            {
                soma = soma + pesos[i];
            }
            Console.Write($"A soma dos pesos é {soma} e a média dos pesos é " + (soma / quantidade));
        }
    }
}
