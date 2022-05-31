using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criar uma classe chamada ConversorAscii
//● Caracter
//Criar métodos:
//● Obter código ascii do caracter. Levar em consideração que pode ser em caixa
//alta ou caixa baixa.
//Obs.: É obrigatório fazer os ifs para descobrir o código ascii.
//Obs.: Criar testes unitários, assim como, ExercicioConversorAscii.

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio03
{
    public class ConversorAscii
    {
        public string Caracteres;
        public int ConverterCodigoAscii()
        {
            int codigo = 0;
            string[] caractere = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", 
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int[] codigoAscii = { 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 
                65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 };
            int quantidade = caractere.Length;
            for (var i = 0; i < quantidade; i++)
            {
                if (Caracteres == caractere[i])
                {
                    codigo = codigoAscii[i];
                    break;
                }

            }
            return codigo;
        }
    }
}
