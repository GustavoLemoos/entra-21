using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.Criar uma classe que irá as notas:
//a.Solicitar a nota 1
//b. Solicitar a nota 2
//c. Solicitar a nota 3
//d. Listar notas
//e. Apresentar média das notas
//f. Apresentar status da média

namespace Entra21.ExerciciosLista
{
    public class Exercicio03
    {
        public void Executar()
        {
            List<double> notas = new List<double>();
            Console.Write("Digite a nota 1: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite a nota 2: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite a nota 3: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            for (var i = 0; i < notas.Count; i++)
            {
                Console.WriteLine($@"Nota{i+ 1} {notas[i]}");
            }
            var media = (notas[0] + notas[1] + notas[2]) / 3;
            if (media >= 7.00)
            {
                Console.Write($@"Média: {media}
Status: aprovado");                
            }
            else if (media >= 4.00 && media < 7.00) 
            {
                Console.Write($@"Média: {media}
Status: em exame");
            }
            else 
            {
                Console.Write($@"Média: {media}
Status: reprovado");
            }
        }
    }
}
