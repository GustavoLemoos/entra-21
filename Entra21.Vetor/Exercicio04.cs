using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um vetor para armazenar as notas de uma disciplina. A disciplina deve
//conter 4 notas.
//Solicite para o usuário o nome e as quatro notas, armazenando as notas em um
//vetor, realize a média destas notas e apresente.

namespace Entra21.Vetor
{
    internal class Exercicio04
    {
        public void Executar()
        {
            int quantidade = 4;
            double[] notas = new double[quantidade];
            string nome = "";
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Digite a nota{1}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                notas[i] = nota;
            }
            double soma = 0.00;
            for (int i = 0; i < notas.Length; i++)
            {
                soma = soma + notas[i];
            }
            Console.Write($"O nome do aluno é {nome} e a sua média é: " + (soma / quantidade));
        }
    }
}
