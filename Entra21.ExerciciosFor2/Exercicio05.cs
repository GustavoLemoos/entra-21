using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio05
    {
        public void Executar()
        {
            var opcao = "";
            var total = 0.00;
            var media = 0.00;
            var quantidadeProdutosConsumidos = 0;
            var quantidadeBolosEscolhidos = 0;
            var quantidadeDocesEscolhidos = 0;
            var quantidadeSanduichesEscolhidos = 0;
            var quantidadePizzasEscolhidas = 0;
            Console.Write("Cardápio: " + "\nCódigo  Tipo        Nome                                        Valor" +
                                         "\n1       Bolos       Bolo Brigadeiro                             R$ 29,50" +
                                         "\n2       Bolos       Bolo Floresta Negra                         R$ 2,00" +
                                         "\n3       Bolos       Bolo Leite com Nutella                      R$ 29,23" +
                                         "\n4       Bolos       Bolo Mousse de Chocolate                    R$ 7,10" +
                                         "\n5       Bolos       Bolo Nega Maluca                            R$ 19,33" +
                                         "\n6       Doces       Bomba de Creme                              R$ 17,71" +
                                         "\n7       Doces       Bomba de Morango                            R$ 4,82" +
                                         "\n8       Sanduíches  Filé-Mignon com fritas e cheddar            R$ 21,16" +
                                         "\n9       Sanduíches  Hambúrguer com queijos, champignon e rúcula R$ 12,70" +
                                         "\n10      Sanduíches  Provolone com salame                        R$ 19,70" +
                                         "\n11      Sanduíches  Vegetariano de berinjela                    R$ 28,22" +
                                         "\n12      Pizzas      Calabresa                                   R$ 8,98" +
                                         "\n13      Pizzas      Napolitana                                  R$ 0,42" +
                                         "\n14      Pizzas      Peruana                                     R$ 18,36" +
                                         "\n15      Pizzas      Portuguesa                                  R$ 27,50" +
                                         "\n16      Sair                                                             ");
            Console.WriteLine("Digite uma opção com base em seu código: ");
            for (; opcao.Trim() != "16";)
            {
                opcao = Console.ReadLine();
                Console.WriteLine("Digite uma opção com base em seu código: ");
            }

        }
    }
}
