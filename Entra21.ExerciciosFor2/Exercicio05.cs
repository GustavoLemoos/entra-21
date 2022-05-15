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
            var opcao = 0;
            var total = 0.00;
            var media = 0.00;
            var quantidadeProdutosConsumidos = 0;
            var quantidadeBolosEscolhidos = 0;
            var quantidadeDocesEscolhidos = 0;
            var quantidadeSanduichesEscolhidos = 0;
            var quantidadePizzasEscolhidas = 0;
            Console.WriteLine("Cardápio: " + "\nCódigo  Tipo        Nome                                        Valor" +
                                         "\n1       Bolos       Bolo Brigadeiro                             R$ 29,50" +
                                         "\n2       Bolos       Bolo Floresta Negra                         R$ 29,50" +
                                         "\n3       Bolos       Bolo Leite com Nutella                      R$ 29,50" +
                                         "\n4       Bolos       Bolo Mousse de Chocolate                    R$ 29,50" +
                                         "\n5       Bolos       Bolo Nega Maluca                            R$ 29,50" +
                                         "\n6       Doces       Bomba de Creme                              R$ 17,71" +
                                         "\n7       Doces       Bomba de Morango                            R$ 17,71" +
                                         "\n8       Sanduíches  Filé-Mignon com fritas e cheddar            R$ 21,16" +
                                         "\n9       Sanduíches  Hambúrguer com queijos, champignon e rúcula R$ 21,16" +
                                         "\n10      Sanduíches  Provolone com salame                        R$ 21,16" +
                                         "\n11      Sanduíches  Vegetariano de berinjela                    R$ 21,16" +
                                         "\n12      Pizzas      Calabresa                                   R$ 8,98" +
                                         "\n13      Pizzas      Napolitana                                  R$ 8,98" +
                                         "\n14      Pizzas      Peruana                                     R$ 8,98" +
                                         "\n15      Pizzas      Portuguesa                                  R$ 8,98" +
                                         "\n16      Sair                                                             ");
            Console.WriteLine("Digite uma opção com base em seu código: ");
            for (var i = 0; opcao != 16; i++)
            {
                opcao = Convert.ToInt32(Console.ReadLine());
                if ((opcao >= 1) && (opcao <= 5))
                {
                    quantidadeBolosEscolhidos++;
                    total = total + 29.50;
                }
                else if ((opcao >= 6) && (opcao <= 7))
                {
                    quantidadeDocesEscolhidos++;
                    total = total + 17.71;
                }
                else if ((opcao >= 8) && (opcao <= 11))
                {
                    quantidadeSanduichesEscolhidos++;
                    total = total + 21.16;
                }
                else if ((opcao >= 12) && (opcao <= 15))
                {
                    quantidadePizzasEscolhidas++;
                    total = total + 8.98;
                }
                else { }
                if (opcao != 16)
                {
                    quantidadeProdutosConsumidos++;
                    media = total / (quantidadeProdutosConsumidos);
                    Console.WriteLine("Digite uma opção com base em seu código: ");
                }
                else { }
            }
            Console.Clear();
            Console.WriteLine("A quantidade de bolos escolhidos é " + quantidadeBolosEscolhidos);
            Console.WriteLine("A quantidade de doces escolhidos é " + quantidadeDocesEscolhidos);
            Console.WriteLine("A quantidade de sanduíches escolhidos é " + quantidadeSanduichesEscolhidos);
            Console.WriteLine("A quantidade de pizzas escolhidas é " + quantidadePizzasEscolhidas);
            Console.WriteLine("A quantidade de produtos escolhidos é " + quantidadeProdutosConsumidos);
            Console.WriteLine("O valor médio dos itens do pedido é: R$" + media);
            Console.WriteLine("O valor total do pedido é: R$" + total);
        }
    }
}
