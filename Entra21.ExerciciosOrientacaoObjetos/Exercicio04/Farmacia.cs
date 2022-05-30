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
