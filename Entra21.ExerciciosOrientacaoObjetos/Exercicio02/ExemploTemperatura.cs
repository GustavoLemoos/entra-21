using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class ExemploTemperatura
    {
        public void Executar()
        {
            Temperatura temperatura = new Temperatura();
            Console.Write("Digite a unidade da temperatura de origem: ");
            temperatura.TemperaturaOrigem = Console.ReadLine().ToLower();
            Console.Write("Digite o valor da temperatura: ");
            temperatura.Temperaturaa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a unidade da temperatura de destino: ");
            temperatura.TemperaturaDestino = Console.ReadLine().ToLower();
            temperatura.ConverterTemperatura();
            Console.WriteLine("O valor da temperatura de destino é: " + temperatura.Temperaturaa);

        }
    }
}
