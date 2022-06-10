using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioOrientacaoObjetoComListaMaisEstrutura.ExercicioTriangulo
{
    internal class Triangulo
    {
        public double Lado1;
        public double Lado2;
        public double Lado3;
        public int Codigo;

        public bool ValidarTriangulo()
        {
            if (Lado1 < (Lado2 + Lado3) && Lado2 < (Lado1 + Lado3) && Lado3 < (Lado1 + Lado2))
            {
                return true;
            }
            return false;
        }
    }
}
