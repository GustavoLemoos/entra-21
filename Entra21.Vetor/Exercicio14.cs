using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um vetor para armazenar os nomes dos produtos. Apresentar os nomes do menor
//nome até o maior nome.
//Deve listar todos os nomes do menor para o maior.
//Obrigatório utilização de for para apresentar os nomes do menor para o maior.


namespace Entra21.Vetor
{
    internal class Exercicio14
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

                    }
                    else
                    {
                        string nomeAux1 = nomes[j];
                        string nomeAux2 = nomes[i];
                        nomes[i] = nomeAux1;
                        nomes[j] = nomeAux2;
                    }
                }
            }
            Console.Write("Os nomes em ordem crescente de quantidade de caracteres, são: ");
            for (var i = 0; i < nomes.Length; i++)
            {
                Console.Write($"\n{nomes[i]},");
            }
        }
    }
}
