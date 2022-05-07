using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio10
    {
        public void Executar()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int antecessorPar = 0;
            int sucessorImpar = 0;
            string listaAntecessorPar = "";
            string listaSucessorImpar = "";
            int indice = 0;
            if ((numero % 2) == 0)
            {
                antecessorPar = numero - 2;
                sucessorImpar = numero + 1;
                while (indice <= 49)
                {
                    listaAntecessorPar = listaAntecessorPar + "\n" + antecessorPar;
                    listaSucessorImpar = listaAntecessorPar + "\n" + antecessorPar;
                    antecessorPar = antecessorPar - 2;
                    sucessorImpar = sucessorImpar + 2;
                    indice = indice + 1;
                }
            }
            else
            {
                antecessorPar = numero - 2;
                sucessorImpar = numero + 2;
                while (indice <= 49)
                {
                    listaAntecessorPar = listaAntecessorPar + "\n" + antecessorPar;
                    listaSucessorImpar = listaAntecessorPar + "\n" + antecessorPar;
                    antecessorPar = antecessorPar - 2;
                    sucessorImpar = sucessorImpar + 2;
                    indice = indice + 1;
                }
            }
            Console.Write("Os 50 números antecessores pares, são:" + "\n" +
                listaAntecessorPar + "\nOs 50 números sucessores ímpares, são:" +
                "\n" + listaSucessorImpar);

        }

    }
}
