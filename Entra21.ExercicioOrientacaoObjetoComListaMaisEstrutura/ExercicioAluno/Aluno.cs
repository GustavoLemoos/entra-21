using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioOrientacaoObjetoComListaMaisEstrutura.ExercicioAluno
{
    internal class Aluno
    {
        public string Nome;
        public int CodigoMatricula;
        public int Idade;
        public string MateriaFavorita;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularMedia()
        {
            double media = (Nota1 + Nota2 + Nota3) / 3;
            return media;
        }

        public AlunoStatus ObterStatus()
        {
            AlunoStatus alunoStatus = AlunoStatus.Aprovado;
            if (CalcularMedia() >= 5.00 && CalcularMedia() < 7.00)
            {
                alunoStatus = AlunoStatus.EmExame;
            }
            else if (CalcularMedia() < 5.00)
            {
                
                alunoStatus = AlunoStatus.Reprovado;
            }
            return alunoStatus;
        }
    }
}
