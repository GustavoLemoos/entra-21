namespace Entra21.ExerciciosLista.ExemplosListasObjetos
{
    public class Produto
    {
        public int Codigo;
        public string Nome;
        public double PrecoUnitario;
        public int Quantidade;
        public ProdutoLocalizacao Localizacao;

        public double CalcularPrecoTotal()
        {
            var preco = Quantidade * PrecoUnitario;

            return preco;
        }


    }
}
