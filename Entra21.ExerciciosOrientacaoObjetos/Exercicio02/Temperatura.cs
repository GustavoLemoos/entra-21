using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criar uma classe chamada Temperatura, armazenar as seguintes propriedades:
//● temperatura de origem
//● Temperatura de destino
//● Temperatura

//Criar métodos:
//● Calcular Celsius
//● Calcular Kelvin
//● Calcular Fahrenheit

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class Temperatura
    {
        public string TemperaturaOrigem;
        public string TemperaturaDestino;
        public double Temperaturaa;

        public double CalcularCelsius()
        {
            Temperaturaa = TemperaturaOrigem == "k"
                ? (Temperaturaa - 273)
                : (Temperaturaa - 32) / 1.8;

            return Temperaturaa;
        }

        public double CalcularKelvin()
        {
            Temperaturaa = TemperaturaOrigem == "c"
                ? (Temperaturaa + 273)
                : (Temperaturaa - 32) / 1.8 + 273;

            return Temperaturaa;
        }

        public double CalcularFahrenheit()
        {
            Temperaturaa = TemperaturaOrigem == "k"
                ? (Temperaturaa - 273) * 1.8 + 32
                : Temperaturaa * 1.8 + 32;

            return Temperaturaa;
        }
    }
}
