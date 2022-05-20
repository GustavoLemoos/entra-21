using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie dois vetores para guardar o nome e preço de 7 produtos e apresente o
//nome e preço dos sete produtos.


namespace Entra21.Vetor
{
    internal class Exercicio03
    {
        public void Executar()
        {
            int quantidade = 7;
            string[] nomes = new string[quantidade];
            double[] precos = new double[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                nomes[i] = nome;
                Console.Write("Digite o preço do produto: R$");
                double preco = Convert.ToDouble(Console.ReadLine());
                precos[i] = preco;
            }
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"O produto{i} informado é {nomes[i]}, e o seu valor é R${precos[i]}");
            }
        }
    }
}
