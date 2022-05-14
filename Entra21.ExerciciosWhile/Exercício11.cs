using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercício11
    {
        public void Executar()
        {
            Console.Write("Digite um número: ");
            double numero01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite um número: ");
            double numero02 = Convert.ToDouble(Console.ReadLine());
            string opcao = "";
            Console.Write("------Menu------" + "\n 1 - Somar" + "\n 2 - Subtrair" + "\n 3 - Multiplicar" +
                "\n 4 - Dividir" + "\n 5- Sair" + "\n----------------" + "\n" + "\nEscolha uma das opções do menu com base no código: ");
            opcao = Console.ReadLine();
            while (opcao.Trim() != "5")
            {
                if (opcao == "1")
                {
                    Console.WriteLine("A soma dos números apresentados é igual a: " + (numero01 + numero02));
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("A subtração dos números apresentados é igual a: " + (numero01 - numero02));
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("A multiplicação dos números apresentados é igual a: " + (numero01 * numero02));
                }
                else
                {
                    Console.WriteLine("A divisão dos números apresentados é igual a: " + (numero01 / numero02));
                }
                Console.Write("Escolha uma das opções do menu com base no código: ");
                opcao = Console.ReadLine();
            }

        }
    }
}
