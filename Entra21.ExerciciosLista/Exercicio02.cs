using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criar uma classe que irá armazenar os conteúdos passados até o momento:
//a.Adicionar o conteúdo "Como fazer um bolo"
//b. Listar conteúdos
//c. Alterar conteúdo "Como fazer um bolo" para "Algoritmos onde vivem? Do que
//se alimentam”
//d. Adicionar o conteúdo "variáveis"
//e. Adicionar o conteúdo "Mais para frente"
//f. Alterar o conteúdo “Mais para frente" por "If com E"
//g. Adicionar o conteúdo "If com OU”;
//h. Adicionar o conteúdo "While";
//i.Adicionar o conteúdo "For"
//j. Listar conteúdos
//k. Adicionar o conteúdo "Vetor"
//l. Adicionar o conteúdo "Vetor”
//m. Apagar os conteúdos "Vetor"
//n. Adicionar o conteúdo "Vetor"
//o. Alterar o conteúdo"Vetor" para "Vetor com For um amor na minha vida”
//p. Listar conteúdos
//q. Adicionar o conteúdo "Classe propriedades e métodos"
//r. Listar conteúdos

namespace Entra21.ExerciciosLista
{
    public class Exercicio02
    {
        public void Executar()
        {
            List<string> conteudos = new List<string>();
            conteudos.Add("Como fazer um bolo");
            Console.WriteLine("Conteúdo1" + " " + conteudos[0]);
            var indicePosicaoConteudo = conteudos.IndexOf("Como fazer um bolo");
            conteudos[indicePosicaoConteudo] = "Algoritmos onde vivem? Do que se alimentam";
            conteudos.Add("variáveis");
            conteudos.Add("Mais para frente");
            indicePosicaoConteudo = conteudos.IndexOf("Mais para frente");
            conteudos[indicePosicaoConteudo] = "If com E";
            conteudos.Add("If com OU");
            conteudos.Add("While");
            conteudos.Add("For");
            for (var i = 0; i < conteudos.Count; i++)
            {
                Console.WriteLine("Conteúdo" + (i + 1) + " é " + conteudos[i]);
            }
            conteudos.Add("Vetor");
            conteudos.Add("Vetor");
            conteudos.Remove("Vetor");
            conteudos.Remove("Vetor");
            conteudos.Add("Vetor");
            indicePosicaoConteudo = conteudos.IndexOf("Vetor");
            conteudos[indicePosicaoConteudo] = "Vetor com For um amor na minha vida";
            for (var i = 0; i < conteudos.Count; i++)
            {
                Console.WriteLine("Conteúdo" + (i + 1) + " é " + conteudos[i]);
            }
            conteudos.Add("Classe propriedades e métodos");
            for (var i = 0; i < conteudos.Count; i++)
            {
                Console.WriteLine("Conteúdo" + (i + 1) + " é " + conteudos[i]);
            }
        }

    }
}
