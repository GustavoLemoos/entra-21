using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Criar uma classe que irá armazenar os melhores filmes de todos os tempos.
//a. Adicionar o filme "Dragon Ball Evollution";
//b.Adicionar o filme "Titanic";
//c.Adicionar o filme "Lanterna verde";
//d.Listar os filmes armazenados na lista;
//e.Adicionar o filme "";
//f.Alterar o filme "Dragon Ball Evollution" para "Dragon Ball Super: Broly”;
//g. Remover filme "Lanterna verde";
//h.Verificar se a lista contém o filme "Lanterna verde" apresentando para o
//usuário se está ou não cadastrado;
//i.Adicionar o filme "Quarteto fantástico";
//j.Listar os filmes armazenados na lista;
//k.Alterar o filme "Titanic" para “Titanic 2”;
//l.Listar os filmes armazenados na lista;
//m.Verificar se filme "A Lagoa Azul” existe na lista, informando para o usuário

namespace Entra21.ExerciciosLista
{
    internal class Exercicio01
    {
        public void Executar()
        {
            List<string> filmes = new List<string>();
            filmes.Add("Dragon Ball Evolution");
            filmes.Add("Titanic");
            filmes.Add("Lanterna Verde");
            Console.WriteLine($@"Filme[0]  {filmes[0]} 
Filme[1]  {filmes[1]} 
Filme[2]  {filmes[2]}");
            filmes.Add("");
            var indicePosicaoFilme = filmes.IndexOf("Dragon Ball Evolution");
            filmes[indicePosicaoFilme] = "Dragon Ball Super: Broly";
            filmes.Remove("Lanterna Verde");
            if (filmes.Contains("Lanterna Verde") == true)
            {
                Console.WriteLine("O filme Lanterna Verde está cadastrado.");
            }
            else
            {
                Console.WriteLine("O filme Lanterna Verde não está cadastrado.");

            }
            filmes.Add("Quarteto Fantástico");
            for (var i = 0; i < filmes.Count; i++)
            {
                Console.WriteLine("Filme" + (i + 1) + " " + filmes[i]);
            }
            indicePosicaoFilme = filmes.IndexOf("Titanic");
            filmes[indicePosicaoFilme] = "Titanic 2";
            for (var i = 0; i < filmes.Count; i++)
            {
                Console.WriteLine("Filme" + (i + 1) + " " + filmes[i]);
            }
            if (filmes.Contains("Lagoa Azul") == true)
            {
                Console.WriteLine("O filme Lagoa Azul está cadastrado.");
            }
            else
            {
                Console.WriteLine("O filme Lagoa Azul não está cadastrado.");

            }

        }
    }
}
