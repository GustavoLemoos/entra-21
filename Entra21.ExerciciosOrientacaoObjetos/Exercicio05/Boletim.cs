using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criar uma classe chamada Boletim armazenar:
//● Vetor para notas de matemática
//● Vetor para notas de português
//● Vetor para notas de física
//● Vetor para notas de química
//● Vetor para notas de geografia
//● Vetor para notas de história
//● Vetor para notas de filosofia
//● Vetor para notas de sociologia
//● Vetor para notas de biologia
//● Quantidade de dias letivos
//● Quantidade de presenças
//Criar métodos:
//● Calcular média de matemática
//● Calcular média de português
//● ….
//● Calcular quantidade de faltas
//● Calcular percentual de presença
//● Calcular percentual de faltas
//● Apresentar boletim (n precisa de teste)
//● Validar em exame
//● Validar reprovado
//● Calcular média geral
//● Validar passou de ano
//Criar testes unitários validando os métodos acima.
//Criar classe ExemploBoletim

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio05
{
    public class Boletim
    {
        public double[] NotasMatematica = new double[3];
        public double[] NotasPortugues = new double[3];
        public double[] NotasFisica = new double[3];
        public double[] NotasQuimica = new double[3];
        public double[] NotasGeografia = new double[3];
        public double[] NotasHistoria = new double[3];
        public double[] NotasFilosofia = new double[3];
        public double[] NotasSociologia = new double[3];
        public double[] NotasBiologia = new double[3];
        public int QuantidadeDiasLetivos;
        public int QuantidadePresenca;

        public double CalcularMediaMatematica()
        {
            double mediaMatematica = 0.0;
            for (var i = 0; i < 3; i++)
            {
                mediaMatematica = mediaMatematica + NotasMatematica[i];
                if (i == 2)
                {
                    mediaMatematica = mediaMatematica / 3;
                }
            }
            return mediaMatematica;
        }

        public double CalcularMediaPortugues()
        {
            double mediaPortugues = 0.0;
            for (var i = 0; i < 3; i++)
            {
                mediaPortugues = mediaPortugues + NotasPortugues[i];
                if (i == 2)
                {
                    mediaPortugues = mediaPortugues / 3;
                }
            }
            return mediaPortugues;

        }

        public double CalcularMediaFisica()
        {
            double mediaFisica = 0.0;

            for (var i = 0; i < 3; i++)
            {
                mediaFisica = mediaFisica + NotasFisica[i];
                if (i == 2)
                {
                    mediaFisica = mediaFisica / 3;
                }
            }
            return mediaFisica;

        }

        public double CalcularMediaQuimica()
        {
            double mediaQuimica = 0.0;

            for (var i = 0; i < 3; i++)
            {
                mediaQuimica = mediaQuimica + NotasQuimica[i];
                if (i == 2)
                {
                    mediaQuimica = mediaQuimica / 3;
                }
            }
            return mediaQuimica;

        }

        public double CalcularMediaGeografia()
        {
            double mediaGeografia = 0.0;

            for (var i = 0; i < 3; i++)
            {
                mediaGeografia = mediaGeografia + NotasGeografia[i];
                if (i == 2)
                {
                    mediaGeografia = mediaGeografia / 3;
                }
            }
            return mediaGeografia;

        }

        public double CalcularMediaHistoria()
        {
            double mediaHistoria = 0.0;

            for (var i = 0; i < 3; i++)
            {
                mediaHistoria = mediaHistoria + NotasHistoria[i];
                if (i == 2)
                {
                    mediaHistoria = mediaHistoria / 3;
                }
            }
            return mediaHistoria;

        }

        public double CalcularMediaFilosofia()
        {
            double mediaFilosofia = 0.0;

            for (var i = 0; i < 3; i++)
            {
                mediaFilosofia = mediaFilosofia + NotasFilosofia[i];
                if (i == 2)
                {
                    mediaFilosofia = mediaFilosofia / 3;
                }
            }
            return mediaFilosofia;

        }

        public double CalcularMediaSociologia()
        {
            double mediaSociologia = 0.0;

            for (var i = 0; i < 3; i++)
            {
                mediaSociologia = mediaSociologia + NotasSociologia[i];
                if (i == 2)
                {
                    mediaSociologia = mediaSociologia / 3;
                }
            }
            return mediaSociologia;

        }

        public double CalcularMediaBiologia()
        {
            double mediaBiologia = 0.0;
            for (var i = 0; i < 3; i++)
            {
                mediaBiologia = mediaBiologia + NotasBiologia[i];
                if (i == 2)
                {
                    mediaBiologia = mediaBiologia / 3;
                }
            }
            return mediaBiologia;

        }

        public double CalcularMediaGeral()
        {
            double mediaGeral = 0.0;
            for (var i = 0; i < 3; i++)
            {
                mediaGeral = mediaGeral + NotasMatematica[i] + NotasPortugues[i] + NotasFisica[i] +
                    NotasQuimica[i] + NotasGeografia[i] + NotasHistoria[i] +
                    NotasFilosofia[i] + NotasSociologia[i] + NotasBiologia[i];
                if (i ==2)
                {
                    mediaGeral = mediaGeral / 9;
                }
            }

            return mediaGeral;
        }

        //public int CalcularQuantidadeFaltas()
        //{

        //}

        //public double CalcularPercentualPresenca()
        //{

        //}

        //public double CalcularPercentualFaltas()
        //{

        //}

        //public string ApresentarBoletim()
        //{
        //    Console.Write($@"");
        //}

        //public string ValidarSeEmExame()
        //{

        //}

        //public string ValidarSeReprovado()
        //{

        //}

        //public string ValidarPassouDeAno()
        //{

        //}
    }
}
