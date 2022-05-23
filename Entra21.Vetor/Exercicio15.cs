using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um vetor para armazenar os nomes dos produtos. Apresentar os nomes do maior
//nome até o menor nome.
//Deve listar todos os nomes do maior para o menor.
//Obrigatório utilização de for para apresentar os nomes do maior para o menor

namespace Entra21.Vetor
{
    internal class Exercicio15
    {
        public void Executar()
        {
            int quantidade = 5;
            string[] nomes = new string[quantidade];
            for (var i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                nomes[i] = nome.Trim();
            }

            for (var i = 0; i < nomes.Length; i++)
            {
                for (var j = 0; j < nomes.Length; j++)
                {
                    if (nomes[i].Length >= nomes[j].Length)
                    {
                        string nomeAux1 = nomes[j];
                        string nomeAux2 = nomes[i];
                        nomes[i] = nomeAux1;
                        nomes[j] = nomeAux2;
                    }
                    else
                    {
                    }
                }
            }
            Console.Write("Os nomes em ordem decrescente de quantidade de caracteres, são: ");
            for (var i = 0; i < nomes.Length; i++)
            {
                Console.Write($"\n{nomes[i]},");
            }
        }
    }
}
