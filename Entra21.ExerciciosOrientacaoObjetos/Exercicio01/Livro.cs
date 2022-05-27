using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie uma classe chamada Livro para armazenar as seguintes informações
//● Título
//● Autor
//● Código ISBN
//● Idioma original
//● Data de lançamento
//● Quantidade de páginas
//● Quantidade de páginas lidas
//● Quantidade de releituras

//Crie os seguintes métodos:
//● ApresentarTituloAutor
//● ApresentarQuantidadePaginasParaLer
//● ApresentarQuantidadePaginasLidasNoTotal

//Criar testes unitários validando os métodos criados acima

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio01
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public string CodigoIsbn;
        public string IdiomaOriginal;
        public DateTime DataLancamento;
        public int QuantidadePaginas;
        public int QuantidadePaginasLidas;
        public int QuantidadeReleituras;

        public void ApresentarTituloAutor()
        {
            Console.Write($"Título: {Titulo} + \nAutor: + {Autor}");
        }

        public void ApresentarQuantidadePaginasParaLer()
        {
            Console.Write($"A quantidade de páginas para ler é: + {QuantidadePaginas - QuantidadePaginasLidas}");
            QuantidadeReleituras = QuantidadeReleituras + QuantidadePaginasLidas;
        }

        public void ApresentarQuantidadeTotalPaginasLidas()
        {
            Console.Write($"A quantidade total de páginas lidas é: {QuantidadeReleituras}");
        }
    }
}
