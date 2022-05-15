using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio06
    {
        public void Executar()
        {
            var nome = "";
            var nomeMenor = Int32.MaxValue;
            var nomeMenorLista = "";
            var nomeMaior = Int32.MinValue;
            var nomeMaiorLista = "";
            var nomeMenosQuantidadeCartoesAmarelos = "";
            var nomeMaisQuantidadeCartoesAmarelos = "";
            var nomeMenosQuantidadeCartoesVermelhos = "";
            var nomeMaisQuantidadeCartoesVermelhos = "";
            var idade = 0;
            var peso = 0.00;
            var pesoMenor = 0.00;
            var pesoMaior = 0.00;
            var sexo = "";
            var sexoFemininoQuantidade = 0;
            var sexoMasculinoQuantidade = 0;
            var altura = 0.00;
            var alturaMaior = 0.00;
            var quantidadeGolsMarcados = 0;
            var quantidadeCartoesAmarelos = 0;
            var quantidadeCartoesVermelhos = 0;

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite o nome do jogador: ");
                nome = Console.ReadLine();
                if (nome.Trim().Length <= nomeMenor)
                {
                    nomeMenor = nome.Trim().Length;
                    nomeMenorLista = nome;
                }
                else { }
                if (nome.Trim().Length >= nomeMaior)
                {
                    nomeMaior = nome.Trim().Length;
                    nomeMaiorLista = nome;
                }
                else { }
            }
            Console.WriteLine("O jogador o menor nome é " + nomeMenorLista);
            Console.WriteLine("O jogador com o maior nome é " + nomeMaiorLista);
        }
    }
}
