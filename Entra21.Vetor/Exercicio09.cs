using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criar dois vetores, no primeiro solicite os nomes para o usuário, o outro vetor deverá ser
//preenchido da seguinte forma:
//-Primeira posição vetor 2 recebe última posição vetor 1.
//- Segunda posição vetor 2 recebe penúltima posição vetor 1.
//- E continua até terminar o preenchimento do vetor 2.
//Obrigatório utilização de for para preencher o vetor 2.
//O tamanho do vetor você escolhe, mínimo de 5 posições.

namespace Entra21.Vetor
{
    internal class Exercicio09
    {
        public void Executar()
        {
            var quantidade = 5;
            string[] nomes = new string[quantidade];
            string[] nomesDesordenados = new string[quantidade];
            for (var i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Digite o nome do usuário{i+1}: ");
                string nome = Console.ReadLine();
                nomes[i] = nome;
            }

            for (var i = 0; i < nomesDesordenados.Length; i++)
            {
                nomesDesordenados[i] = nomes[quantidade - (i + 1)];
            }

            Console.Write("O vetor nomes armazena: ");
            for (var i = 0; i < nomes.Length; i++)
            {
                Console.Write($"{nomes[i]}, ");
            }

            Console.Write("\nO vetor nomesDesordenados armazena: ");
            for (var i = 0; i < nomesDesordenados.Length; i++)
            {
                Console.Write($"{nomesDesordenados[i]}, ");
            }
        }
    }
}
