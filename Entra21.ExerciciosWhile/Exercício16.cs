using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercício16
    {
        public void Executar()
        {
            Console.Write("Digite um texto: ");
            string texto = Console.ReadLine();
            int quantidadeCaracteres = texto.Length, indice = 0;
            int indiceA = 0, indiceB = 0, indiceC = 0, indiceD = 0, indiceE = 0, indiceF = 0, indiceG = 0, indiceH = 0,
                indiceI = 0, indiceJ = 0, indiceK = 0, indiceL = 0, indiceM = 0, indiceN = 0, indiceO = 0, indiceP = 0,
                indiceQ = 0, indiceR = 0, indiceS = 0, indiceT = 0, indiceU = 0, indiceV = 0, indiceW = 0, indiceX = 0,
                indiceY = 0, indiceZ = 0, indiceVazio = 0;
            int quantidadeA = 0, quantidadeB = 0, quantidadeC = 0, quantidadeD = 0, quantidadeE = 0, quantidadeF = 0,
                quantidadeG = 0, quantidadeH = 0, quantidadeI = 0, quantidadeJ = 0, quantidadeK = 0, quantidadeL = 0,
                quantidadeM = 0, quantidadeN = 0, quantidadeO = 0, quantidadeP = 0, quantidadeQ = 0, quantidadeR = 0,
                quantidadeS = 0, quantidadeT = 0, quantidadeU = 0, quantidadeV = 0, quantidadeW = 0, quantidadeX = 0,
                quantidadeY = 0, quantidadeZ = 0, quantidadeVazio = 0;
            while (indice < quantidadeCaracteres)
            {
                if (texto.ToLower().Substring(indice, 1) == "a")
                {
                    quantidadeA = quantidadeA + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "b")
                {
                    quantidadeB = quantidadeB + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "c")
                {
                    quantidadeC = quantidadeC + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "d")
                {
                    quantidadeD = quantidadeD + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "e")
                {
                    quantidadeE = quantidadeE + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "f")
                {
                    quantidadeF = quantidadeF + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "g")
                {
                    quantidadeG = quantidadeG + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "h")
                {
                    quantidadeH = quantidadeH + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "i")
                {
                    quantidadeI = quantidadeI + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "j")
                {
                    quantidadeJ = quantidadeJ + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "k")
                {
                    quantidadeK = quantidadeK + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "l")
                {
                    quantidadeL = quantidadeL + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "m")
                {
                    quantidadeM = quantidadeM + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "n")
                {
                    quantidadeN = quantidadeN + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "o")
                {
                    quantidadeO = quantidadeO + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "p")
                {
                    quantidadeP = quantidadeP + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "q")
                {
                    quantidadeQ = quantidadeQ + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "r")
                {
                    quantidadeR = quantidadeR + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "s")
                {
                    quantidadeS = quantidadeS + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "t")
                {
                    quantidadeT = quantidadeT + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "u")
                {
                    quantidadeU = quantidadeU + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "v")
                {
                    quantidadeV = quantidadeV + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "w")
                {
                    quantidadeW = quantidadeW + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "x")
                {
                    quantidadeX = quantidadeX + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "y")
                {
                    quantidadeY = quantidadeY + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "z")
                {
                    quantidadeZ = quantidadeZ + 1;
                    indice = indice + 1;
                }
                else if (texto.ToLower().Substring(indice, 1) == "vazio")
                {
                    quantidadeVazio = quantidadeVazio + 1;
                    indice = indice + 1;
                }
                else
                {

                }
            }
            Console.Write("\nQuantidade A =" + quantidadeA +
                                "\nQuantidade B =" + quantidadeB +
                                "\nQuantidade C =" + quantidadeC +
                                "\nQuantidade D =" + quantidadeD +
                                "\nQuantidade E =" + quantidadeE +
                                "\nQuantidade F =" + quantidadeF +
                                "\nQuantidade G =" + quantidadeG +
                                "\nQuantidade H =" + quantidadeH +
                                "\nQuantidade I =" + quantidadeI +
                                "\nQuantidade J =" + quantidadeJ +
                                "\nQuantidade K =" + quantidadeK +
                                "\nQuantidade L =" + quantidadeL +
                                "\nQuantidade M =" + quantidadeM +
                                "\nQuantidade N =" + quantidadeN +
                                "\nQuantidade O =" + quantidadeO +
                                "\nQuantidade P =" + quantidadeP +
                                "\nQuantidade Q =" + quantidadeQ +
                                "\nQuantidade R =" + quantidadeR +
                                "\nQuantidade S =" + quantidadeS +
                                "\nQuantidade T =" + quantidadeT +
                                "\nQuantidade U =" + quantidadeU +
                                "\nQuantidade V =" + quantidadeV +
                                "\nQuantidade W =" + quantidadeX +
                                "\nQuantidade X =" + quantidadeW +
                                "\nQuantidade Y =" + quantidadeY +
                                "\nQuantidade Z =" + quantidadeZ +
                                "\nQuantidade Vazio =" + quantidadeVazio);
        }
    }
}
