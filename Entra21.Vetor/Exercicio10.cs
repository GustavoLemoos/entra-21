using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criei um vetor e solicite 8 números. Crie outro vetor preenchendo ele da seguinte forma.
//- Primeira posição do vetor 2 recebe a soma da última posição do vetor 1 e a primeira
//posição do vetor 1.
//- Segunda posição do vetor 2 recebe a soma da primeira posição do vetor 1 e a
//segunda posição do vetor 1.
//- E continua até terminar o preenchimento do vetor 2.
//Obrigatório utilização de for para preencher o vetor 2.

namespace Entra21.Vetor
{
    internal class Exercicio10
    {
        public void Executar()
        {
            var quantidade = 8;
            double[] numeros = new double[quantidade];
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um número: ");
                double numero = Convert.ToDouble(Console.ReadLine());
                numeros[i] = numero;
            }

            double[] numerosDesordenados = new double[quantidade];
            for (var i = 0; i < numerosDesordenados.Length; i++)
            {
                if (i == 7)
                {
                    numerosDesordenados[(quantidade - (i + 1))] = (numeros[(quantidade - (i + 1))] + numeros[(quantidade - 1)]);
                }
                else
                {
                    numerosDesordenados[(quantidade - (i + 1))] = (numeros[(quantidade - (i + 1))] + numeros[(quantidade - (i + 2))]);
                }
            }

            Console.Write("O vetor numeros armazena: ");
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]}, ");
            }
            Console.Write("\nO vetor numerosDesordenados armazena: ");
            for (var i = 0; i < numerosDesordenados.Length; i++)
            {
                Console.Write($"{numerosDesordenados[i]}, ");
            }
        }
    }
}
