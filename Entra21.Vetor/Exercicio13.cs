using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um vetor de números e solicite. Após isto apresentar os números em ordem
//decrescente.
//Obrigatório utilização de for para apresentar em ordem decrescente

namespace Entra21.Vetor
{
    internal class Exercicio13
    {
        public void Executar()
        {
            int quantidade = 10;
            double[] numeros = new double[quantidade];
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um número: ");
                double numero = Convert.ToDouble(Console.ReadLine());
                numeros[i] = numero;
            }

            for (var i = 0; i < numeros.Length; i++)
            {
                for (var j = 0; j < numeros.Length; j++)
                {
                    if (numeros[i] >= numeros[j])
                    {
                        double numeroAux1 = numeros[j];
                        double numeroAux2 = numeros[i];
                        numeros[i] = numeroAux1;
                        numeros[j] = numeroAux2;
                    }
                    else
                    {
                    }
                }
            }

            Console.Write("Os números em ordem decrescente são: ");
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]}, ");
            }
        }
    }
}
