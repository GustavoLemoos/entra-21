using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Solicite a altura de 4 animais, apresente ao final a altura do animal com a
//menor altura.

namespace Entra21.Vetor
{
    internal class Exercicio07
    {
        public void Executar()
        {
            int quantidade = 4;
            string[] nomes = new string[quantidade];
            double[] alturas = new double[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o nome do animal: ");
                string nome = Console.ReadLine();
                nomes[i] = nome;
                Console.Write("Digite a altura do animal: ");
                double altura = Convert.ToDouble(Console.ReadLine());
                alturas[i] = altura;
            }
            string nomeMenorAltura = ";";
            double menorAltura = double.MaxValue;
            for (int i = 0; i < quantidade; i++)
            {
                if (alturas[i] <= menorAltura)
                {
                    nomeMenorAltura = nomes[i];
                    menorAltura = alturas[i];
                }
            }
            Console.Write($"O animal com a menor altura é {nomeMenorAltura} e a sua altura é {menorAltura}");
        }
    }
}
