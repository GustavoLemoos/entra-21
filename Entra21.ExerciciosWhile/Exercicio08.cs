using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio08
    {
        public void Executar()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int operador1 = 0, multiplicacao = 0;
            while (((multiplicacao + numero) <= 1000) && (multiplicacao >= 0))
            {
                operador1 = operador1 + 1;
                multiplicacao = numero * operador1;
                Console.Write("\n" + numero + "*" + operador1 + "=" + multiplicacao);
            }
        }
    }
}
