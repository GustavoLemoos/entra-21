using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio04
    {
        public void Executar()
        {
            Console.Write("Digite um número: ");
            var numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Os 50 números antecessores pares são:");
            for (var i = 0; i < 50; i++)
            {
                if ((numero % 2) == 0)
                {
                    Console.WriteLine(numero - (i + 1) * 2);
                }
                else
                {
                    Console.WriteLine((numero-1) - (i + 1) * 2);
                }
            }
            Console.WriteLine("Os 50 números sucessores ímpares são:");
            for (var i = 0; i < 50; i++)
            {
                if ((numero % 2) == 0)
                {
                    Console.WriteLine((numero + 1) + (i * 2));
                }
                else
                {
                    Console.WriteLine(numero + ((i + 1) * 2));
                }
            }
        }
    }
}
