using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio03
    {
        public void Executar()
        {
            Console.Write("Digite um número: ");
            var numero = Convert.ToDouble(Console.ReadLine());
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine((i + 1) + " x " + numero + " = " + ((i + 1) * numero));
            }
        }
    }
}
