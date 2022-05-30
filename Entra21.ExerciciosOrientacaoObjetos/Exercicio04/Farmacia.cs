using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criar uma classe chamada Farmácia com as seguintes propriedades:
//● Razão social
//● CNPJ
//● Nome produto 1
//● Preço produto 1
//● Categoria produto 1
//● Nome produto 2
//● Preço produto 2
//● Categoria produto 2
//● Nome produto 3
//● Preço produto 3
//● Categoria produto 3

//Criar métodos:

//● Apresentar total do pedido

//● Apresentar total do pedido por categoria de produto
//Exemplo:
//Antiinflamatório total 15,78
//Antibiótico total 32.50
//● Apresentar quantidade por categoria
//● Apresentar nome do produto mais caro
//● Apresentar nome e categoria do produto mais barato.

//Criar classe ExemploFarmacia
//Criar testes unitários validando os métodos acima.
//Obs.: Pode utilizar vetor se desejar.

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio04
{
    public class Farmacia
    {
        public string RazaoSocial;
        public string CNPJ;
        public string NomeProduto1;
        public double PrecoProduto1;
        public string CategoriaProduto1;
        public string NomeProduto2;
        public double PrecoProduto2;
        public string CategoriaProduto2;
        public string NomeProduto3;
        public double PrecoProduto3;
        public string CategoriaProduto3;

        public double ApresentarTotalPedido()
        {
            var totalPedido = PrecoProduto1 + PrecoProduto2 + PrecoProduto3;


            return totalPedido;
        }

        public string ApresentarTotalPedidoPorCategoriaProduto()
        {
            var totalPedidoPorCategoria1 = 0.0;
            var totalPedidoPorCategoria2 = 0.0;
            var totalPedidoPorCategoria3 = 0.0;
            string totalPedidoPorCategoria;
            if (CategoriaProduto1 == CategoriaProduto2 && CategoriaProduto1 == CategoriaProduto3)
            {
                totalPedidoPorCategoria1 = PrecoProduto1 + PrecoProduto2 + PrecoProduto3;
                totalPedidoPorCategoria = CategoriaProduto1 + "é R$" + totalPedidoPorCategoria1;
            }
            else if (CategoriaProduto1 == CategoriaProduto2 && CategoriaProduto1 != CategoriaProduto3)
            {
                totalPedidoPorCategoria1 = PrecoProduto1 + PrecoProduto2;
                totalPedidoPorCategoria2 = PrecoProduto3;
                totalPedidoPorCategoria = CategoriaProduto1 + " é R$" + totalPedidoPorCategoria1 + " e " + CategoriaProduto2 + " é R$" +
                    totalPedidoPorCategoria2;
            }
            else if (CategoriaProduto1 != CategoriaProduto2 && CategoriaProduto2 == CategoriaProduto3)
            {
                totalPedidoPorCategoria1 = PrecoProduto1;
                totalPedidoPorCategoria2 = PrecoProduto2 + PrecoProduto3;
                totalPedidoPorCategoria = CategoriaProduto1 + " é R$" + totalPedidoPorCategoria1 + " e " + CategoriaProduto2 + " é R$" +
                    totalPedidoPorCategoria2;
            }
            else if (CategoriaProduto1 != CategoriaProduto2 && CategoriaProduto1 == CategoriaProduto3)
            {
                totalPedidoPorCategoria1 = PrecoProduto1 + PrecoProduto3;
                totalPedidoPorCategoria2 = PrecoProduto2;
                totalPedidoPorCategoria = CategoriaProduto1 + " é R$" + totalPedidoPorCategoria1 + " e " + CategoriaProduto2 + " é R$" +
                    totalPedidoPorCategoria2;
            }
            else
            {
                totalPedidoPorCategoria1 = PrecoProduto1;
                totalPedidoPorCategoria2 = PrecoProduto2;
                totalPedidoPorCategoria3 = PrecoProduto3;
                totalPedidoPorCategoria = CategoriaProduto1 + " é R$" + totalPedidoPorCategoria1 + " e " + CategoriaProduto2 + " é R$" +
                    totalPedidoPorCategoria2 + " e " + CategoriaProduto3 + " é R$" + totalPedidoPorCategoria3;
            }
            return totalPedidoPorCategoria;
        }

        public string ApresentarQuantidadeProdutoPorCategoria()
        {

            string quantidadePedidoPorCategoria;
            if (NomeProduto1 == NomeProduto2 && NomeProduto1 == NomeProduto3)
            {
                quantidadePedidoPorCategoria = CategoriaProduto1 + " é " + 3;
            }
            else if (NomeProduto1 == NomeProduto2 && NomeProduto1 != NomeProduto3)
            {
                quantidadePedidoPorCategoria = CategoriaProduto1 + " é " + 2 + " e " + CategoriaProduto3 + " é " + 1;
            }
            else if (NomeProduto1 != NomeProduto2 && NomeProduto2 == NomeProduto3)
            {
                quantidadePedidoPorCategoria = CategoriaProduto1 + " é " + 1 + " e " + CategoriaProduto2 + " é " + 2;
            }
            else if (NomeProduto1 != NomeProduto2 && NomeProduto1 == NomeProduto3)
            {
                quantidadePedidoPorCategoria = CategoriaProduto1 + " é " + 2 + " e " + CategoriaProduto2 + " é " + 1;
            }
            else
            {
                quantidadePedidoPorCategoria = CategoriaProduto1 + " é " + 1 + " e " + CategoriaProduto2 + " é " + 1 + " e " + CategoriaProduto3 + " é " + 1;
            }
            return quantidadePedidoPorCategoria;
        }

        public string ApresentarNomeProdutoMaisCaro()
        {
            var produtoMaisCaro = "";
            if (PrecoProduto1 >= PrecoProduto2 && PrecoProduto1 >= PrecoProduto3)
            {
                produtoMaisCaro = NomeProduto1;
            }
            else if (PrecoProduto2 >= PrecoProduto1 && PrecoProduto2 >= PrecoProduto3)
            {
                produtoMaisCaro = NomeProduto2;
            }
            else 
            {
                produtoMaisCaro = NomeProduto3;
            }
            return produtoMaisCaro;
        }

        public string ApresentarNomeJuntoDaCategoriaProdutoMaisBarato()
        {
            var produtoMaisBarato = "";
            if (PrecoProduto1 <= PrecoProduto2 && PrecoProduto1 <= PrecoProduto3)
            {
                produtoMaisBarato = NomeProduto1 + " e sua categoria é " + CategoriaProduto1;
            }
            else if (PrecoProduto2 >= PrecoProduto1 && PrecoProduto2 >= PrecoProduto3)
            {
                produtoMaisBarato = NomeProduto2 + " e sua categoria é " + CategoriaProduto2;
            }
            else
            {
                produtoMaisBarato = NomeProduto3 + " e sua categoria é " + CategoriaProduto3;
            }
            return produtoMaisBarato;
        }
    }
}
