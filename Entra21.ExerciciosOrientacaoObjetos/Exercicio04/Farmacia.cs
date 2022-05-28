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
        public string NomeProduto;
        public double PrecoProduto;
        public double TotalPedido;
        public string CategoriaProduto;
        public int QuantidadeProdutos;

        public void CriarVetores()
        {
            string[] NomeProduto = new string[QuantidadeProdutos];
            double[] PrecoProduto = new double[QuantidadeProdutos];
            string[] CategoriaProduto = new string[QuantidadeProdutos];
        }

        public double ApresentarTotalPedido()
        {
            for (var i = 0.0; i < QuantidadeProdutos; i++)
            {
                TotalPedido = TotalPedido + PrecoProduto[i];
            }
            Console.WriteLine($"O valor total do pedido é: R${TotalPedido}");

            return TotalPedido;
        }

        //public double ApresentarTotalPedidoPorCategoriaProduto()
        //{

        //}

        //public int ApresentarQuantidadeProdutoPorCategoria()
        //{

        //}

        //public string ApresentarNomeProdutoMaisCaro()
        //{

        //}

        //public string ApresentarNomeJuntoDaCategoriaProdutoMaisBarato()
        //{

        //}
    }
}
