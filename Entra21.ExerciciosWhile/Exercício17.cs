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
            int segundos = 59, minutos = 59, horas = 23;
            int indiceSegundos = 59;
            int indice = 1;
            while (indice <= 86400)
            {
                Console.WriteLine(horas + ":" + minutos + ":" + segundos);
                if ((indice % 60) == 0)
                {
                    minutos = minutos - 1;
                }
                else { }
                if (minutos < 0)
                {
                    minutos = 59;
                }
                else { }
                if ((indice % 3600) == 0)
                {
                    horas = horas - 1;
                }
                else { }
                indiceSegundos = indiceSegundos - 1;
                segundos = segundos - 1;
                if (indiceSegundos < 0)
                {
                    indiceSegundos = 59;
                    segundos = 59;
                }
                else
                { }
                indice = indice + 1;
            }
        }
    }
}
