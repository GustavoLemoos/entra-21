using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercício15
    {
        public void Executar()
        {
            Console.Write("Digite um texto: ");
            string texto = Console.ReadLine();
            int quantidadeCaracteres = texto.Length, indice = 0;
            while (indice < quantidadeCaracteres)
            {
                Console.WriteLine(texto.Substring(indice, 1));
                indice = indice + 1;
            }

        }
    }
}
