using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um vetor e solicite os números. Crie outros dois vetores, um deles irá armazenar
//somente os números pares do vetor 1, o outro irá armazenar somente os números ímpares
//do vetor 1.
//Obrigatório utilização de for para preencher o vetor 2 e 3

namespace Entra21.Vetor
{
    internal class Exercicio11
    {
        public void Executar()
        {
            int quantidade = 10, quantidadePares = 0, quantidadeImpares = 0;
            int[] numeros = new int[quantidade];
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite um número inteiro: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                numeros[i] = numero;
                if ((numero % 2) == 0)
                {
                    quantidadePares++;
                }
                else
                {
                    quantidadeImpares++;
                }
            }

            int[] numerosPares = new int[quantidadePares];
            int posicaoPar = 0;
            int[] numerosImpares = new int[quantidadeImpares];
            int posicaoImpar = 0;
            for (var i = 0; i < numeros.Length; i++)
            {
                if ((numeros[i] % 2) == 0)
                {
                    numerosPares[posicaoPar] = numeros[i];
                    posicaoPar++;
                }
                else
                {
                    numerosImpares[posicaoImpar] = numeros[i];
                    posicaoImpar++;
                }
            }

            Console.Write("O vetor numeros armazena: ");
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]}, ");
            }

            Console.Write("\nO vetor numerosPares armazena: ");
            for (var i = 0; i < numerosPares.Length; i++)
            {
                Console.Write($"{numerosPares[i]}, ");
            }

            Console.Write("\nO vetor numerosImpares armazena: ");
            for (var i = 0; i < numerosImpares.Length; i++)
            {
                Console.Write($"{numerosImpares[i]}, ");
            }
        }
    }
}
