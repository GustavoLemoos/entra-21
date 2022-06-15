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
            for (var i = 0; i < alunos.Count(); i++)
            {
                Aluno alunoAtual = alunos[i];
                if (alunoAtual.CodigoMatricula == codigoMatricula)
                {
                    alunoAtual.Nome = nome;
                    alunoAtual.Idade = idade;
                    alunoAtual.MateriaFavorita = materiaFavorita;
                    return true;
                }
            }
            return false;
        }

        public bool EditarNotasAluno(int codigoMatricula, double nota1, double nota2, double nota3)
        {
            for (var i = 0; i < alunos.Count(); i++)
            {
                Aluno alunoAtual = alunos[i];
                if (alunoAtual.CodigoMatricula == codigoMatricula)
                {
                    alunoAtual.Nota1 = nota1;
                    alunoAtual.Nota2 = nota2;
                    alunoAtual.Nota3 = nota3;
                    return true;
                }
            }
            return false;
        }

        public List<string> ObterNomes()
        {
            List<string> nomes = new List<string>();
            for (var i = 0; i < alunos.Count(); i++)
            {
                nomes.Add(alunos[i].Nome);
            }
            return nomes;
        }

        public List<string> ObterAprovados()
        {
            List<string> aprovados = new List<string>();
            for (var i = 0; i < alunos.Count(); i++)
            {
                var alunoAtual = alunos[i];
                if (alunoAtual.ObterStatus() == AlunoStatus.Aprovado)
                {
                    aprovados.Add(alunoAtual.Nome);
                }
            }
            return aprovados;
        }

        public List<string> ObterReprovados()
        {
            List<string> reprovados = new List<string>();
            for (var i = 0; i < alunos.Count(); i++)
            {
                var alunoAtual = alunos[i];
                if (alunoAtual.ObterStatus() == AlunoStatus.Reprovado)
                {
                    reprovados.Add(alunoAtual.Nome);
                }
            }
            return reprovados;
        }

        public List<string> ObterEmExame()
        {
            List<string> alunosEmExame = new List<string>();
            for (var i = 0; i < alunos.Count(); i++)
            {
                var alunoAtual = alunos[i];
                if (alunoAtual.ObterStatus() == AlunoStatus.EmExame)
                {
                    alunosEmExame.Add(alunoAtual.Nome);
                }
            }
            return alunosEmExame;
        }

        public double ObterMediaPorCodigoMatricula(int codigoMatricula)
        {
            for (var i = 0; i < alunos.Count(); i++)
            {
                var alunoAtual = alunos[i];
                if (alunoAtual.CodigoMatricula == codigoMatricula)
                {
                    var media = alunoAtual.CalcularMedia();
                    return media;
                }
            }
            return 0.00;
        }

        public AlunoStatus ObterStatusPorCodigoMatricula(int codigoMatricula)
        {
            for (var i = 0; i < alunos.Count(); i++)
            {
                var alunoAtual = alunos[i];
                if (alunoAtual.CodigoMatricula == codigoMatricula)
                {
                    var status = alunoAtual.ObterStatus();
                    return status;
                }
            }
            return AlunoStatus.Aprovado;
        }

        public double ObterMediaIdades()
        {
            var mediaIdades = 0;
            for (var i = 0; i < alunos.Count(); i++)
            {
                var alunoAtual = alunos[i];
                mediaIdades += alunos[i].Idade;
                if (i == alunos.Count())
                {
                    mediaIdades = mediaIdades / i;
                }
            }
            return mediaIdades;
        }
    }
}
