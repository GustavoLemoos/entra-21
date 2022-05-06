using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio09
    {
        public void Executar()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int operador = numero - 1;
            int multiplicacao = numero;
            if(numero == 0)
            {
                Console.Write("O fatorial do número informado é igual a: 0");
            }
            else
            {
                while (operador >= 1)
                {
                    multiplicacao = multiplicacao * operador;
                    operador = operador - 1;
                }
                Console.Write("O fatorial do número informado é igual a:" + multiplicacao);
            }
            
        }
    }
}
