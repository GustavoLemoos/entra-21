using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um vetor para guardar 16 números inteiros.
//Preencha todas as posições com números e apresente a soma destes números.


namespace Entra21.Vetor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int[] numeros = new int[16];
            int soma = 0;
            for (int i = 0; i < 16; i++)
            {
                Console.Write("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                numeros[i] = numero;
                soma = soma + numeros[i];
            }
            Console.Write($"A soma dos números é {soma}");
        }
    }
}
