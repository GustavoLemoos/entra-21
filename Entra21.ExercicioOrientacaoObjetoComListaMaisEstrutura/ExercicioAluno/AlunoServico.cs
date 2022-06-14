using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioOrientacaoObjetoComListaMaisEstrutura.ExercicioAluno
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();
        private int codigoAtual = 1;
        public void AdicionarAluno(string nome, int idade, string materiaFavorita, double nota1, double nota2, double nota3)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.MateriaFavorita = materiaFavorita;
            aluno.CodigoMatricula = codigoAtual;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;
            codigoAtual++;
            alunos.Add(aluno);
        }

        public bool RemoverAluno(string nome)
        {
            for (var i = 0; i < alunos.Count(); i++)
            {
                Aluno alunoVerificado = alunos[i];
                if (alunoVerificado.Nome == nome)
                {
                    alunos.Remove(alunoVerificado);
                    return true;
                }
            }
            return false;
        }

        public List<Aluno> ApresentarListaAlunos()
        {
            return alunos;
        }

        public bool EditarDadosCadastrais(int codigoMatricula, string nome, int idade, string materiaFavorita)
        {

            return false;
        }

    }
}
