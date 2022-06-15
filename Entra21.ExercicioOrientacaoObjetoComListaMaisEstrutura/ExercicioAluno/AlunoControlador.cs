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

        public void GerenciarMenu()
        {
            int codigo = 0;
            while (codigo != 13)
            {
                Console.Clear();
                codigo = ApresentarSolicitarMenu();

                Console.Clear();

                if (codigo == 1)
                {
                    Cadastrar();
                }
                else if (codigo == 2)
                {
                    Apagar();
                }
                else if (codigo == 3)
                {
                    ApresentarAlunos();
                }
                else if (codigo == 4)
                {
                    EditarDadosCadastraisAluno();
                }
                else if (codigo == 5)
                {
                    EditarNotasAlunoControlador();
                }
                else if (codigo == 6)
                {
                    ListarAlunos();
                }
                else if (codigo == 7)
                {
                    ListarAlunosAprovados();
                }
                else if (codigo == 8)
                {
                    ListarAlunosReprovados();
                }
                else if (codigo == 9)
                {
                    ListarAlunosEmExame();
                }
                else if (codigo == 10)
                {
                    VisualizarMediaAluno();
                }
                else if (codigo == 11)
                {
                    VisualizarStatusAluno();
                }
                else if (codigo == 12)
                {
                    VisualizarStatusAluno();
                }
                Console.WriteLine("\n\nAperte alguma tecla para continuar...");
                Console.ReadKey();
            }
        }

        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"MENU:
1 - Cadastrar
2 - Apagar
3 - Apresentr alunos
4 - Editar dados cadastrais do aluno
5 - Editar notas do aluno
6 - Listar todos alunos
7 - Listar alunos aprovados
8 - Listar alunos reprovados
9 - Listar alunos em exame
10 - Visualizar média do aluno
11 - Visualizar status do aluno
12 - Visualizar média das idades
13 - Sair");

            int codigo = SolicitarCodigo();

            return codigo;
        }

        private int SolicitarCodigo()
        {
            int codigo = 0;
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite o código: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite um menu válido");
                }
            }

            return codigo;
        }

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

        private void ListarAlunos()
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

        private void ListarAlunosAprovados()
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

        private void ListarAlunosReprovados()
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

        private void ListarAlunosEmExame()
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

        private void VisualizarMediaAluno()
        {
            ApresentarAlunos();
            Console.WriteLine("");
            Console.WriteLine("Digite o código de matrícula do aluno desejado: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A média do aluno é: ");
            alunoServico.ObterMediaPorCodigoMatricula(codigoMatricula);
        }

        private void VisualizarStatusAluno()
        {
            ApresentarAlunos();
            Console.WriteLine("");
            Console.WriteLine("Digite o código de matrícula do aluno desejado: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O status do aluno é: ");
            alunoServico.ObterStatusPorCodigoMatricula(codigoMatricula);
        }

        private void VisualizarMediaIdades()
        {
            Console.WriteLine("A média de idades é: ");
            alunoServico.ObterMediaIdades();
        }
    }
}
