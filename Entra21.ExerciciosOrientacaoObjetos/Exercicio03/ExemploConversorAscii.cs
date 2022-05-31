using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio03
{
    public class ExemploConversorAscii
    {
        public void Executar()
        {
            ConversorAscii exemploConversorAscii = new ConversorAscii();
            Console.Write("Digite o seu caracter: ");
            exemploConversorAscii.Caracteres = Console.ReadLine();
            Console.Write($"O código convertido em Ascii é {exemploConversorAscii.ConverterCodigoAscii()}");
        }
    }
}
