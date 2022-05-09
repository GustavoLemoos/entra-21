using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercício17
    {
        public void Executar()
        {
            Console.Write("Temporizador: ");
            int tempoSegundos = 86399;
            int indiceSegundo = 0;
            while (indiceSegundo < 86399)
            {
                //Horas
                Console.WriteLine((tempoSegundos / 60) / 60);
                //Minutos

                tempoSegundos = tempoSegundos - 1;
                indiceSegundo = indiceSegundo + 1;
            }
        }
    }
}
