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
            int indiceSegundos = 59, indiceMinutos = 59, indiceHoras = 3600;
            int indice = 0;
            while (indice < 86399)
            {
                Console.WriteLine(horas + ":" + minutos + ":" + segundos);
                indiceSegundos = indiceSegundos - 1;
                segundos = segundos - 1;
                if (indiceSegundos < 0)
                {
                    indiceSegundos = 59;
                    segundos = 59;
                    indiceMinutos = indiceMinutos - 1;
                    minutos = minutos - 1;
                }
                else
                { }
                if (indiceMinutos < 0)
                {
                    indiceMinutos = 60;
                    minutos = 59;
                }
                else { }
                indiceHoras = indiceHoras - 1;
                if (indiceHoras < 0)
                {
                    indiceHoras = 3600;
                    horas = horas - 1;
                }
                indice = indice + 1;
            }
        }
    }
}
