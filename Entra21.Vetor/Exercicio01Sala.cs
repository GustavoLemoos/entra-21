using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Solicitar nome, sobrenome e apresentar o nome completo de 3 pessoas, utilizando o vetor.

namespace Entra21.Vetor
{
    internal class Exercicio01Sala
    {
        public void Executar()
        {
            string[] nomes = new string[3];
            string[] sobrenomes = new string[3];
            Console.Write("Digite o seu nome: ");
            nomes[0] = Console.ReadLine();
            Console.Write("Digite o seu sobrenome: ");
            sobrenomes[0] = Console.ReadLine();
            Console.Write("Digite o seu nome: ");
            nomes[1] = Console.ReadLine();
            Console.Write("Digite o seu sobrenome: ");
            sobrenomes[1] = Console.ReadLine();
            Console.Write("Digite o seu nome: ");
            nomes[2] = Console.ReadLine();
            Console.Write("Digite o seu sobrenome: ");
            sobrenomes[2] = Console.ReadLine();
            Console.WriteLine("O nome completo da pessoa 1 é " + nomes[0] + " " + sobrenomes[0]);
            Console.WriteLine("O nome completo da pessoa 2 é " + nomes[1] + " " + sobrenomes[1]);
            Console.WriteLine("O nome completo da pessoa 3 é " + nomes[2] + " " + sobrenomes[2]);
        }
    }
}
