namespace Entra21.ExerciciosLista.ExemplosListasObjetos
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();
        private int codigoAtual = 1;
        // encapsulamento + tipoRetorno + NomeMetodo(parametros)
        // parametro -> "Suprir necessidade do método"
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            // Instanciar um objeto da classe Produto
            Produto produto = new Produto();

            //Atribuir valor para as Propriedades com os dados passados como parâmetro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            // Atribuir o código novo para o objeto do produto
            produto.Codigo = codigoAtual;


            // Adicionar 1 no código atual para quando criar um novo produto o produto conter outro código
            produto.Codigo = codigoAtual;

            // Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);

        }

        public bool Editar(int codigoParaAlterar, string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            // Obtém o produto desejado da lista de produtos
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            // Verifica se não foi possível encontrar o produto
            if (produtoParaAlterar == null)
            {
                // Retorna falso, pois não existe produto com o código dos parâmetros
                return false;
            }

            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            // Retorna verdadeiro, pois foi possível alterar o produto
            return true;
        }

        public bool Apagar(int codigo)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                // Resgatando de uma lista de tipos primitivos
                // int numero = numeros[i];

                // Resgatando de uma lista de objetos
                Produto produto = produtos[i];
                if (produto.Codigo == codigo)
                {
                    // Posso remover com o indice do objeto desejado
                    //produtos.RemoveAt(i);

                    // Posso remover com o objeto desejado
                    produtos.Remove(produto);
                    // Retorna true, pois o produto com o codigo desejado foi removido da lista
                    return true;
                }

            }
            // Retorna false, pois não foi encontrado produto com o código desejado, ou seja, nenhum elemento foi removido da lista
            return false;
        }

        public List<Produto> ObterTodos()
        {
            return produtos;
        }

        public Produto ObterPorCodigo(int codigo)
        {
            // Percorrer todos os elementos para encontrar o produto filtrando por código
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obter o produto da lista de produtos em determinado indice
                var produtoAtual = produtos[i];

                // Verifica se o produto atual da lista percorrida é o desejado
                if (produtoAtual.Codigo == codigo)
                {
                    // Retorna o produto encontrado
                    return produtoAtual;
                }
            }

            // Retorna null, caso não encontre um produto com o código passado como parâmetro
            return null;
        }

        public Produto ObterMenorPrecoUnitario()
        {
            double menorPrecoUnitario = double.MaxValue;
            Produto produtoMenorPrecoUnitario = null;

            for (int i = 0; i < produtos.Count; i++)
            {
                Produto produto = produtos[i];

                if (produto.PrecoUnitario < menorPrecoUnitario)
                {
                    menorPrecoUnitario = produto.PrecoUnitario;

                    produtoMenorPrecoUnitario = produto;
                }
            }
            return produtoMenorPrecoUnitario;
        }

        public List<double> ObterTodosPrecos()
        {
            var precos = new List<double>();

            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];

                precos.Add(produto.CalcularPrecoTotal());
            }

            return precos;
        }

        public List<double> ObterPrecosTotaisFiltrandoPorLocalizacao(ProdutoLocalizacao localizacao)
        {
            var precos = new List<double>();

            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];

                if (produto.Localizacao == localizacao)
                {
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }

            return precos;
        }

        public List<double> ObterPrecosTotaisDoArmazem()
        {
            var precos = new List<double>();

            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];

                if (produto.Localizacao == ProdutoLocalizacao.Armazem)
                {
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }

            return precos;
        }
    }
}
