using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio02
    {
        public void Executar()
        {
            var quantidadeCarrosCadastrar = 0;
            Console.Write("Digite a quantidade de carros à cadastrar: ");
            quantidadeCarrosCadastrar = Convert.ToInt32(Console.ReadLine());
            var anoCarro = 0;
            var modelo = "";
            var valorCarro = 0.00;
            var nomeComecaG = 0;
            var nomeComecaA = 0;
            var somaValorCarro = 0.00;
            var somaAnoCarro = 0.00;
            for (var i = 0; i < quantidadeCarrosCadastrar; i++)
            {
                Console.WriteLine("Digite o modelo do carro: ");
                modelo = Console.ReadLine();
                Console.WriteLine("Digite o valor do carro: R$");
                valorCarro = Convert.ToDouble(Console.ReadLine());
                somaValorCarro = somaValorCarro + valorCarro;
                Console.WriteLine("Digite o ano do carro: ");
                anoCarro = Convert.ToInt32(Console.ReadLine());
                somaAnoCarro = somaAnoCarro + anoCarro;
                if (modelo.Trim().ToLower().StartsWith("g") == true)
                {
                    nomeComecaG = nomeComecaG + 1;
                }
                else if (modelo.Trim().ToLower().StartsWith("a") == true)
                {
                    nomeComecaA = nomeComecaA + 1;
                }
            }
            Console.WriteLine("A média do ano dos carros é igual a " + (somaAnoCarro / quantidadeCarrosCadastrar));
            Console.WriteLine("A média do valor dos carroes é igual a R$" + (somaValorCarro / quantidadeCarrosCadastrar));
            Console.WriteLine("A quantidade de carros que começam com a letra G é igual a " + nomeComecaG);
            Console.WriteLine("A quantidade de carros que começam com a letra A é igual a " + nomeComecaA);
        }
    }
}
