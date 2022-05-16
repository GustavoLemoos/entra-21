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
            var nomePesoMenor = "";
            var nomePesoMaior = "";
            var nomeAlturaMaior = "";
            var nomeMenosQuantidadeCartoesAmarelos = "";
            var nomeMaisQuantidadeCartoesAmarelos = "";
            var nomeMenosQuantidadeCartoesVermelhos = "";
            var nomeMaisQuantidadeCartoesVermelhos = "";
            var idade = 0;
            var peso = 0.00;
            var pesoMenor = Double.MaxValue;
            var pesoMaior = Double.MinValue;
            var sexo = "";
            var sexoFemininoQuantidade = 0;
            var sexoMasculinoQuantidade = 0;
            var altura = 0.00;
            var alturaMaior = 0.00;
            var quantidadeGolsMarcados = 0;
            var quantidadeCartoesAmarelos = 0;
            var quantidadeCartoesAmarelosMenor = Int32.MaxValue;
            var quantidadeCartoesAmarelosMaior = Int32.MinValue;
            var quantidadeCartoesVermelhos = 0;
            var quantidadeCartoesVermelhosMenor = Int32.MaxValue;
            var quantidadeCartoesVermelhosMaior = Int32.MinValue;

            for (var i = 0; i < 22; i++)
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
                Console.WriteLine("Digite a idade do jogador: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o peso do jogador: ");
                peso = Convert.ToDouble(Console.ReadLine());
                if (peso <= pesoMenor)
                {
                    pesoMenor = peso;
                    nomePesoMenor = nome;
                }
                else { }
                if (peso >= pesoMaior)
                {
                    pesoMaior = peso;
                    nomePesoMaior = nome;
                }
                else { }
                Console.WriteLine("Digite o sexo do jogador: ");
                sexo = Console.ReadLine();
                if (sexo.Trim().ToLower() == "feminino")
                {
                    sexoFemininoQuantidade = sexoFemininoQuantidade + 1;
                }
                else
                {
                    sexoMasculinoQuantidade = sexoMasculinoQuantidade + 1;
                }
                Console.WriteLine("Digite a altura do jogador: ");
                altura = Convert.ToDouble(Console.ReadLine());
                if (altura >= alturaMaior)
                {
                    nomeAlturaMaior = nome;
                    alturaMaior = altura;
                }
                Console.WriteLine("Digite a quantidade de gols marcados pelo jogador: ");
                quantidadeGolsMarcados = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a quantidade cartões amarelos recebidos pelo jogador: ");
                quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                if (quantidadeCartoesAmarelos <= quantidadeCartoesAmarelosMenor)
                {
                    quantidadeCartoesAmarelosMenor = quantidadeCartoesAmarelos;
                    nomeMenosQuantidadeCartoesAmarelos = nome;
                }
                else { }
                if (quantidadeCartoesAmarelos >= quantidadeCartoesAmarelosMaior)
                {
                    quantidadeCartoesAmarelosMaior = quantidadeCartoesAmarelos;
                    nomeMaisQuantidadeCartoesAmarelos = nome;
                }
                else { }
                Console.WriteLine("Digite a quantidade cartões vermelhos recebidos pelo jogador: ");
                quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());
                if (quantidadeCartoesVermelhos <= quantidadeCartoesVermelhosMenor)
                {
                    quantidadeCartoesVermelhosMenor = quantidadeCartoesVermelhos;
                    nomeMenosQuantidadeCartoesVermelhos = nome;
                }
                else { }
                if (quantidadeCartoesVermelhos >= quantidadeCartoesVermelhosMaior)
                {
                    quantidadeCartoesVermelhosMaior = quantidadeCartoesVermelhos;
                    nomeMaisQuantidadeCartoesVermelhos = nome;
                }
                else { }
            }
            Console.WriteLine("O jogador o menor nome é " + nomeMenorLista);
            Console.WriteLine("O jogador com o maior nome é " + nomeMaiorLista);
            Console.WriteLine("O jogador com o menor peso é " + nomePesoMenor + " e o seu peso é igual a " + pesoMenor + "kg");
            Console.WriteLine("O jogador com o maior peso é " + nomePesoMaior + " e o seu peso é igual a " + pesoMaior + "kg");
            Console.WriteLine("A quantidade de jogadores do sexo feminino é " + sexoFemininoQuantidade);
            Console.WriteLine("A quantidade de jogadores do sexo masculino é " + sexoMasculinoQuantidade);
            Console.WriteLine("O jogador com a maior altura é " + nomeAlturaMaior + " e a sua altura é igual a " + alturaMaior + "m");
            Console.WriteLine("O jogador com a menor quantidade de cartões amarelos recebidos é " + nomeMenosQuantidadeCartoesAmarelos +
                " e a quantidade de cartões amarelos é igual a " + quantidadeCartoesAmarelosMenor);
            Console.WriteLine("O jogador com a maior quantidade de cartões amarelos recebidos é " + nomeMaisQuantidadeCartoesAmarelos +
                " e a quantidade de cartões amarelos é igual a " + quantidadeCartoesAmarelosMaior);
            Console.WriteLine("O jogador com a menor quantidade de cartões vermelhos recebidos é " + nomeMenosQuantidadeCartoesVermelhos +
                " e a quantidade de cartões vermelhos é igual a " + quantidadeCartoesVermelhosMenor);
            Console.WriteLine("O jogador com a maior quantidade de cartões vermelhos recebidos é " + nomeMaisQuantidadeCartoesVermelhos +
                " e a quantidade de cartões vermelhos é igual a " + quantidadeCartoesVermelhosMaior);
        }
    }
}
