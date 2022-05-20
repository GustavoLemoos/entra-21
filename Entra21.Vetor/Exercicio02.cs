using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um vetor para guardar 10 nomes e apresente os dez nomes.


namespace Entra21.Vetor
{
    internal class Exercicio02
    {
        public void Executar()
        {
            int quantidade = 10;
            string[] nomes = new string[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite um nome: ");
                string nome = Console.ReadLine();
                nomes[i] = nome;
            }
            Console.WriteLine("Os nomes informados são:");
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(nomes[i] + "\n");
            }
        }
    }
}
