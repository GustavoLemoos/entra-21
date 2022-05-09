using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercício14
    {
        public void Executar()
        {
            string caractere = "";
            Console.Write("Informe a quantidade de caracteres que serão digitados: ");
            int quantidadeCaracteres = Convert.ToInt32(Console.ReadLine());
            int indice = 0;
            while (indice < quantidadeCaracteres)
            {
                Console.Write("Digite um caractere: ");
                caractere = caractere + Console.ReadLine();
                indice = indice + 1;
            }
            Console.Write(caractere);
        }
    }
}
