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
            int indiceSegundos = 0, indiceMinutos = 0, indiceHoras = 0;
            int indice = 0;
            while (indice < 86399)
            {
                Console.Write(horas + ":" + minutos + ":" + segundos);
                segundos = segundos - 1;
                if ((segundos < 0))
                {
                    segundos = 59;
                }
                else
                { }
                indiceMinutos = indiceMinutos + 1;
                if ((indiceMinutos%3600)  1 )
                indice = indice + 1;
            }
        }
    }
}
