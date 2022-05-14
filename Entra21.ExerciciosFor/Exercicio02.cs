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
            var anoCarro = 0;
            var modelo = "";
            var valorCarro = 0.00;
            var nomeComecaG = 0;
            var nomeComecaA = 0;
            Console.Write("Digite a quantidade de carros à cadastrar: ");
            quantidadeCarrosCadastrar = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; indice < quantidadeCarrosCadastrar; i++)
            {
                Console.WriteLine("Digite o modelo do carro: ");
                modelo = Console.ReadLine();
                Console.WriteLine("Digite o valor do carro: R$");
                valorCarro = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o ano do carro: ");
                anoCarro = Convert.ToInt32(Console.ReadLine());
                if (modelo.Trim().ToLower().StartsWith("g") == true)
                {

                }
            }


        }
    }
}
