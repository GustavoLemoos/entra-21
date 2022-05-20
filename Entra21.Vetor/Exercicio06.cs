using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Solicite a idade de 9 pessoas, apresente ao final a pessoa com a maior
//idade.

namespace Entra21.Vetor
{
    internal class Exercicio06
    {
        public void Executar()
        {
            int quantidade = 9;
            int[] idades = new int[quantidade];
            string[] nomes = new string[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o seu nome: ");
                string nome = Console.ReadLine();
                nomes[i] = nome;
                Console.Write("Digite a sua idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                idades[i] = idade;
            }
            string nomeMaiorIdade = "";
            int maiorIdade = int.MinValue;
            for (int i = 0; i < quantidade; i++)
            {
                if (idades[i] >= maiorIdade)
                {
                    nomeMaiorIdade = nomes[i];
                    maiorIdade = idades[i];
                }
            }
            Console.Write("A pessoa com a maior idade é " + nomeMaiorIdade + " e a sua idade é " + maiorIdade + " anos");
        }
    }
}
