using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioOrientacaoObjetoComListaMaisEstrutura.ExercicioTriangulo
{
    internal class TrianguloControlador
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            int codigo = 0;

            while (codigo != 6)
            {
                Console.Clear();

                codigo = ApresentarSolicitarMenu();

                if (codigo == 1)
                {
                    ApresentarTriangulos();
                }
                else if (codigo == 2)
                {
                    Cadastrar();
                }
                else if (codigo == 3)
                {
                    Editar();
                }
                else if (codigo == 4)
                {
                    Apagar();
                }
                else if (codigo == 5)
                {
                    ApresentarTriangulo();
                }
                Console.WriteLine("\n\nAperte alguma tecla para continuar...");
                Console.ReadKey();
            }
        }

        private void ApresentarTriangulo()
        {
            ApresentarTriangulos();

            Console.Write("Digite o código do triângulo a ser detalhado");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var triangulo = trianguloServico.ObterPorCodigo(codigo);

            if (triangulo == null)
            {
                Console.WriteLine("Triângulo não encontrado");

                return;
            }

            Console.Clear();
            Console.WriteLine($@"Código: {triangulo.Codigo}
Lado1: {triangulo.Lado1}
Lado2: {triangulo.Lado2}
Lado3: {triangulo.Lado3}");
        }

        private void ApresentarTriangulos()
        {
            var triangulos = trianguloServico.ObterTodos();

            if (triangulos.Count == 0)
            {
                Console.WriteLine("Nenhum triângulo foi cadastrado");
                return;
            }

            Console.WriteLine("Lista de triângulos");
            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];
                Console.WriteLine($@"Código {trianguloAtual.Codigo}
Lado1: {trianguloAtual.Lado1}
Lado2: {trianguloAtual.Lado2}
Lado3: {trianguloAtual.Lado3}");
            }
        }

        private void Apagar()
        {
            ApresentarTriangulos();

            Console.WriteLine("Digite o código do triângulo a ser apagado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var trianguloApagado = trianguloServico.Apagar(codigo);

            Console.WriteLine(trianguloApagado == true
                ? "Triângulo removido com sucesso"
                : "Nenhum triângulo cadastrado com o código inserido");
        }

        private void Cadastrar()
        {
            Console.WriteLine("Digite o lado1 do triângulo: ");
            var lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o lado2 do triângulo: ");
            var lado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o lado3 do triângulo: ");
            var lado3 = Convert.ToDouble(Console.ReadLine());
            trianguloServico.AdicionarLadosTriangulo(lado1, lado2, lado3);
        }

        private void Editar()
        {
            ApresentarTriangulos();

            Console.WriteLine("Digite o código do triângulo a ser editado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o lado1: ");
            var lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o lado2: ");
            var lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o lado3: ");
            var lado3 = Convert.ToDouble(Console.ReadLine());

            var alterou = trianguloServico.Editar(lado1, lado2, lado3, codigo);

            if (alterou == false)
            {
                Console.WriteLine("Código digitado não é válido");
            }
            else
            {
                Console.WriteLine("Triângulo alterado com sucesso");
            }
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

        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"MENU:
1 - Apresentar todos os triângulos
2 - Cadastrar
3 - Editar
4 - Apagar
5 - Apresentar triÂngulo desejado
6 Sair");

            int codigo = SolicitarCodigo();

            return codigo;
        }
    }
}
