using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio05
{
    public class ExemploBoletim
    {
        public void Executar()
        {
            Boletim exemploBoletim = new Boletim();
            for (var i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota{i + 1} de matemática: ");
                exemploBoletim.NotasMatematica[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (var i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota{i + 1} de português: ");
                exemploBoletim.NotasPortugues[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (var i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota{i + 1} de física: ");
                exemploBoletim.NotasFisica[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (var i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota{i + 1} de química: ");
                exemploBoletim.NotasQuimica[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (var i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota{i + 1} de geografia: ");
                exemploBoletim.NotasGeografia[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (var i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota{i + 1} de história: ");
                exemploBoletim.NotasHistoria[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (var i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota{i + 1} de filosofia: ");
                exemploBoletim.NotasFilosofia[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (var i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota{i + 1} de sociologia: ");
                exemploBoletim.NotasSociologia[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (var i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota{i + 1} de biologia: ");
                exemploBoletim.NotasBiologia[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"A média de matemática é: {exemploBoletim.CalcularMediaMatematica()}");
            Console.WriteLine($"A média de português é: {exemploBoletim.CalcularMediaPortugues()}");
            Console.WriteLine($"A média de física é: {exemploBoletim.CalcularMediaFisica()}");
            Console.WriteLine($"A média de química é: {exemploBoletim.CalcularMediaQuimica()}");
            Console.WriteLine($"A média de geografia é: {exemploBoletim.CalcularMediaGeografia()}");
            Console.WriteLine($"A média de história é: {exemploBoletim.CalcularMediaHistoria()}");
            Console.WriteLine($"A média de filosofia é: {exemploBoletim.CalcularMediaFilosofia()}");
            Console.WriteLine($"A média de sociologia é: {exemploBoletim.CalcularMediaSociologia()}");
            Console.WriteLine($"A média de biologia é: {exemploBoletim.CalcularMediaBiologia()}");
            Console.WriteLine($"A média geral é: {exemploBoletim.CalcularMediaGeral()}");

            Console.Write("Digite a quantidade de dias letivos: ");
            exemploBoletim.QuantidadeDiasLetivos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade de presenças: ");
            exemploBoletim.QuantidadePresenca = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A quantidade de faltas é: {exemploBoletim.CalcularQuantidadeFaltas()}");
            Console.WriteLine($"O percentual de presença é: {exemploBoletim.CalcularPercentualPresenca()}%");
            Console.WriteLine($"O percentual de faltas é: {exemploBoletim.CalcularPercentualFaltas()}%");



        }
    }
}
