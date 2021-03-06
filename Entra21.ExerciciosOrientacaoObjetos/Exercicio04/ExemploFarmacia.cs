using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio04
{
    public class ExemploFarmacia
    {
        public void Executar()
        {
            Farmacia exemploFarmacia = new Farmacia();
            Console.WriteLine("Digite o nome do produto: ");
            exemploFarmacia.NomeProduto1 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto: R$");
            exemploFarmacia.PrecoProduto1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a categoria do produto: ");
            exemploFarmacia.CategoriaProduto1 = Console.ReadLine();
            Console.WriteLine("Digite o nome do produto: ");
            exemploFarmacia.NomeProduto2 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto: R$");
            exemploFarmacia.PrecoProduto2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a categoria do produto: ");
            exemploFarmacia.CategoriaProduto2 = Console.ReadLine();
            Console.WriteLine("Digite o nome do produto: ");
            exemploFarmacia.NomeProduto3 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto: R$");
            exemploFarmacia.PrecoProduto3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a categoria do produto: ");
            exemploFarmacia.CategoriaProduto3 = Console.ReadLine();

            Console.WriteLine($"O total do pedido é: R${exemploFarmacia.ApresentarTotalPedido()}");
            Console.WriteLine($"O total do pedido por categoria é: {exemploFarmacia.ApresentarTotalPedidoPorCategoriaProduto()}");
            Console.WriteLine($"A quantidade de produtos do pedido por categoria é: {exemploFarmacia.ApresentarQuantidadeProdutoPorCategoria()}");
            Console.WriteLine($"O produto mais caro é: {exemploFarmacia.ApresentarNomeProdutoMaisCaro()}");
            Console.WriteLine($"O produto mais barato é: {exemploFarmacia.ApresentarNomeJuntoDaCategoriaProdutoMaisBarato()}");

        }
    }
}

