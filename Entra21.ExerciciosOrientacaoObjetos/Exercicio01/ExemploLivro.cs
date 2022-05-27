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
            livro.Titulo = "A força";
            livro.Autor = "Hoff";
            livro.ApresentarTituloAutor();

            livro.QuantidadePaginas = 100;
            livro.QuantidadePaginasLidas = 50;
            livro.QuantidadeReleituras = 00;
            livro.ApresentarQuantidadePaginasParaLer();
            livro.ApresentarQuantidadeTotalPaginasLidas();

            //livro.CodigoIsbn = "000-1-2222-3333-4";
            //livro.IdiomaOriginal = "Alemão";
            //livro.DataLancamento = (03/02/2022);



        }
    }
}
