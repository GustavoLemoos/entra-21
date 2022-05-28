using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio01
{
    public class ExemploLivro
    {
        public void Executar()
        {
            Livro livro = new Livro();
            Console.Write("Digite o título do livro: ");
            livro.Titulo = Console.ReadLine();
            Console.Write("Digite o nome autor do livro: ");
            livro.Autor = Console.ReadLine();
            Console.Write("Digite a quantidade de páginas do livro: ");
            livro.QuantidadePaginas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade de páginas lidas do livro: ");
            livro.QuantidadePaginasLidas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade de páginas relidas do livro: ");
            livro.QuantidadeReleituras = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a data de lançamento do livro: ");
            livro.DataLancamento = Convert.ToDateTime(Console.ReadLine());

            livro.ApresentarTituloAutor();
            livro.ApresentarQuantidadePaginasParaLer();
            livro.ApresentarQuantidadeTotalPaginasLidas();
            livro.ApresentarQuantidadeAnosPublicacao();

            //livro.CodigoIsbn = "000-1-2222-3333-4";
            //livro.IdiomaOriginal = "Alemão";

        }
    }
}
