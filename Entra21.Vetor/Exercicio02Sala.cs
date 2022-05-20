using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Solicitar nota1, nota2, nota3, nota4 e apresentar a média, utilizar 1 vetor.

namespace Entra21.Vetor
{
    internal class Exercicio02Sala
    {
        public void Executar()
        {
            double[] notas = new double[4];
            Console.Write("Digite a nota 1: ");
            notas[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 2: ");
            notas[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 3: ");
            notas[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 4: ");
            notas[3] = Convert.ToDouble(Console.ReadLine());
            double media = 0.00;
            media = (notas[0] + notas[1] + notas[2] + notas[3])/4;
            Console.Write("A média das notas informadas é " + media);
        }
    }
}
