using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio13
    {
        public void Executar()
        {
            string nome = "", nomeMenorPeso = "", nomeMaiorPeso = "", nomeMaiorAltura = "", nomeMaiorNome = "", nomeMenorNome = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            string nomeMenosCartoesAmarelos = "", nomeMaisCartoesAmarelos = "";
            string nomeMenosCartoesVermelhos = "", nomeMaisCartoesVermelhos = "";
            int idade = 200;
            double peso = 500.00, menorPeso = 0.00, maiorPeso = 0.00;
            string sexo = "";
            double altura = 0.00, maiorAltura = 0.00;
            int quantidadeJogadoresFeminino = 0;
            int quantidadeJogadoresMasculino = 0;
            int quantidadeGolsMarcados = 0;
            int quantidadeCartoesAmarelos = 0, quantidadeMenosCartoesAmarelos = 0, quantidadeMaisCartoesAmarelos = 1000000;
            int quantidadeCartoesVermelhos = 0, quantidadeMenosCartoesVermelhos = 0, quantidadeMaisCartoesVermelhos = 1000000;
            int indice = 0;
            while (indice < 22)
            {
                Console.Write("Digite o nome do(a) jogador(a): ");
                nome = Console.ReadLine();
                Console.Write("Digite a idade do(a) jogador(a): ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o peso do(a) jogador(a): ");
                peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o sexo do(a) jogador(a) (Feminino ou Masculino): ");
                sexo = Console.ReadLine();
                Console.Write("Digite a altura do(a) jogador(a): ");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a quantidade de gols marcados do(a) jogador(a): ");
                quantidadeGolsMarcados = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a quantidade de cartões amarelos recebidos pelo(a) jogador(a): ");
                quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a quantidade de cartões vermelhos recebidos pelo(a) jogador(a): ");
                quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());
                if (altura == maiorAltura)
                {
                    nomeMaiorAltura = nomeMaiorAltura + "\n" + nome;
                    maiorAltura = altura;
                }
                else if (altura > maiorAltura)
                {
                    nomeMaiorAltura = nome;
                    maiorAltura = altura;
                }
                else { }
                if (peso == maiorPeso)
                {
                    nomeMaiorPeso = nomeMaiorPeso + "\n" + nome;
                    maiorPeso = peso;
                }
                else if (peso > maiorPeso)
                {
                    nomeMaiorPeso = nome;
                    maiorPeso = peso;
                }
                else { }
                if (peso == menorPeso)
                {
                    nomeMenorPeso = nomeMenorPeso + "\n" + nome;
                    menorPeso = peso;
                }
                else if (peso < menorPeso)
                {
                    nomeMenorPeso = nome;
                    menorPeso = peso;
                }
                else { }
                if (nome.Trim().Length > nomeMaiorNome.Trim().Length)
                {
                    nomeMaiorNome = nome;
                }
                else { }
                if (nome.Trim().Length < nomeMenorNome.Trim().Length)
                {
                    nomeMenorNome = nome;
                }
                if (sexo.Trim().ToLower() == "feminino")
                {
                    quantidadeJogadoresFeminino = quantidadeJogadoresFeminino + 1;
                }
                else
                {
                    quantidadeJogadoresMasculino = quantidadeJogadoresMasculino + 1;
                }
                if (quantidadeCartoesAmarelos == quantidadeMaisCartoesAmarelos)
                {
                    nomeMaisCartoesAmarelos = nomeMaisCartoesAmarelos + "\n" + nome;
                }
                else if (quantidadeCartoesAmarelos > quantidadeMaisCartoesAmarelos)
                {
                    quantidadeMaisCartoesAmarelos = quantidadeCartoesAmarelos;
                    nomeMaisCartoesAmarelos = nome;
                }
                else { }
                if (quantidadeCartoesAmarelos == quantidadeMenosCartoesAmarelos)
                {
                    nomeMenosCartoesAmarelos = nomeMenosCartoesAmarelos + "\n" + nome;
                }
                else if (quantidadeCartoesAmarelos < quantidadeMenosCartoesAmarelos)
                {
                    quantidadeMenosCartoesAmarelos = quantidadeCartoesAmarelos;
                    nomeMenosCartoesAmarelos = nome;
                }
                else { }
                if (quantidadeCartoesVermelhos == quantidadeMaisCartoesVermelhos)
                {
                    nomeMaisCartoesVermelhos = nomeMaisCartoesVermelhos + "\n" + nome;
                }
                else if (quantidadeCartoesVermelhos > quantidadeMaisCartoesVermelhos)
                {
                    quantidadeMaisCartoesVermelhos = quantidadeCartoesVermelhos;
                    nomeMaisCartoesVermelhos = nome;
                }
                else { }
                if (quantidadeCartoesVermelhos == quantidadeMenosCartoesVermelhos)
                {
                    nomeMenosCartoesVermelhos = nomeMenosCartoesVermelhos + "\n" + nome;
                }
                else if (quantidadeCartoesVermelhos < quantidadeMenosCartoesVermelhos)
                {
                    quantidadeMenosCartoesVermelhos = quantidadeCartoesVermelhos;
                    nomeMenosCartoesVermelhos = nome;
                }
                else { }


            }
        }
    }
}
