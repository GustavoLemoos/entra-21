using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioOrientacaoObjetoComListaMaisEstrutura.ExercicioAluno
{
    internal class AlunoControlador
    {
        AlunoServico alunoServico = new AlunoServico();
        private void Cadastrar()
        {
            Console.WriteLine("Digite o nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            var idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a matéria favorita: ");
            var materiaFavorita = Console.ReadLine();
            Console.WriteLine("Digite a nota1: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota2: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());
            alunoServico.AdicionarAluno(nome, idade, materiaFavorita, nota1, nota2, nota3);
        }

        private void Apagar()
        {
            ApresentarAlunos();
            Console.WriteLine("Digite o nome do aluno a ser apagado: ");
            var nome = Console.ReadLine();
            var ehAlunoRemovido = alunoServico.RemoverAluno(nome);
            Console.WriteLine(ehAlunoRemovido == true
                ? "Aluno apagado com sucesso"
                : "Não há aluno com o nome informado");
        }

        private void ApresentarAlunos()
        {
            var alunos = alunoServico.ApresentarListaAlunos();
            if (alunos.Count == 0)
            {
                Console.WriteLine("Não há aluno cadastrado");
            }
            else
            {
                Console.WriteLine("Os alunos cadastrados são:");
                for (var i = 0; i < alunos.Count(); i++)
                {
                    Aluno alunoAtual = alunos[i];
                    Console.WriteLine("");
                    Console.WriteLine(alunoAtual.Nome);
                    Console.WriteLine(alunoAtual.CodigoMatricula);
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
        }

        private void EditarDadosCadastraisAluno()
        {
            ApresentarAlunos();
            Console.WriteLine("");
            Console.WriteLine("Digite o código do aluno que deseja editar as informações: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do aluno: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do aluno: ");
            var idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a matéria favorita do aluno: ");
            var materiaFavorita = Console.ReadLine();
            Console.WriteLine("");
            alunoServico.EditarDadosCadastrais(codigoMatricula, nome, idade, materiaFavorita);
            var ehAlunoEditado = alunoServico.EditarDadosCadastrais(codigoMatricula, nome, idade, materiaFavorita);
            Console.WriteLine(ehAlunoEditado == true
                ? "As informações do aluno foram editadas com sucesso"
                : "Código do aluno removido não foi encontrado");
        }

        private void EditarNotasAlunoControlador()
        {
            ApresentarAlunos();
            Console.WriteLine("");
            Console.WriteLine("Digite o código do aluno que deseja editar as notas: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a nota 1 do aluno: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2 do aluno: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 3 do aluno: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            alunoServico.EditarNotasAluno(codigoMatricula, nota1, nota2, nota3);
            var ehAlunoEditado = alunoServico.EditarNotasAluno(codigoMatricula, nota1, nota2, nota3);
            Console.WriteLine(ehAlunoEditado == true
                ? "As notas do aluno foram editadas com sucesso"
                : "Código do aluno editado não foi encontrado");
        }

        public void ListarAlunos()
        {
            var listaAlunos = alunoServico.ObterNomes();
            if (listaAlunos.Count() != 0)
            {
                Console.WriteLine("Alunos: ");
                for (var i = 0; i < listaAlunos.Count(); i++)
                {
                    Console.WriteLine(listaAlunos[i]);
                }
            }
            else
            {
                Console.WriteLine("Não há alunos cadastrados");
            }
        }

        public void ListarAlunosAprovados()
        {
            var listaAlunosAprovados = alunoServico.ObterAprovados();
            if (listaAlunosAprovados.Count() != 0)
            {
                Console.WriteLine("Lista de alunos aprovados: ");
                for (var i = 0; i < listaAlunosAprovados.Count(); i++)
                {
                    Console.WriteLine(listaAlunosAprovados[i]);
                }
            }
            else
            {
                Console.WriteLine("Não há alunos cadastrados");
            }
        }

        public void ListarAlunosReprovados()
        {
            var listaAlunosReprovados = alunoServico.ObterReprovados();
            if (listaAlunosReprovados.Count() != 0)
            {
                Console.WriteLine("Lista de alunos reprovados: ");
                for (var i = 0; i < listaAlunosReprovados.Count(); i++)
                {
                    Console.WriteLine(listaAlunosReprovados[i]);
                }
            }
            else
            {
                Console.WriteLine("Não há alunos cadastrados");
            }
        }

        public void ListarAlunosEmExame()
        {
            var listaAlunosEmExame = alunoServico.ObterEmExame();
            if (listaAlunosEmExame.Count() != 0)
            {
                Console.WriteLine("Lista de alunos em exame: ");
                for (var i = 0; i < listaAlunosEmExame.Count(); i++)
                {
                    Console.WriteLine(listaAlunosEmExame[i]);
                }
            }
            else
            {
                Console.WriteLine("Não há alunos cadastrados");
            }
        }
    }
}
