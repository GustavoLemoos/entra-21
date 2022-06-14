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
    }
}
