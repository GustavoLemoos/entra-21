using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetos.Tests.Exercicio02
{
    public class ExemploTemperatura
    {
        [Fact]
        public void Validar_ConverterTemperatura_Com_TemperaturaOrigem_C_TemperaturaDestino_K()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "c";
            temperatura.Temperaturaa = 27;
            temperatura.TemperaturaDestino = "k";

            // Act
            var temperaturaConvertida = temperatura.ConverterTemperatura();
            var temperaturaConvertidaEsperada = 27+273;

            // Assert
            temperaturaConvertida.Should().Be(temperaturaConvertidaEsperada);
        }

        [Fact]
        public void Validar_ConverterTemperatura_Com_TemperaturaOrigem_C_TemperaturaDestino_F()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "c";
            temperatura.Temperaturaa = 32;
            temperatura.TemperaturaDestino = "f";

            // Act
            var temperaturaConvertida = temperatura.ConverterTemperatura();
            var temperaturaConvertidaEsperada = 32 * 1.8 + 32;

            // Assert
            temperaturaConvertida.Should().Be(temperaturaConvertidaEsperada);
        }

        [Fact]
        public void Validar_ConverterTemperatura_Com_TemperaturaOrigem_K_TemperaturaDestino_C()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "k";
            temperatura.Temperaturaa = 300;
            temperatura.TemperaturaDestino = "c";

            // Act
            var temperaturaConvertida = temperatura.ConverterTemperatura();
            var temperaturaConvertidaEsperada = 300 - 273;

            // Assert
            temperaturaConvertida.Should().Be(temperaturaConvertidaEsperada);
        }

        [Fact]
        public void Validar_ConverterTemperatura_Com_TemperaturaOrigem_K_TemperaturaDestino_F()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "k";
            temperatura.Temperaturaa = 300;
            temperatura.TemperaturaDestino = "f";

            // Act
            var temperaturaConvertida = temperatura.ConverterTemperatura();
            var temperaturaConvertidaEsperada = (300 - 273) * 1.8 +32;

            // Assert
            temperaturaConvertida.Should().Be(temperaturaConvertidaEsperada);
        }

        [Fact]
        public void Validar_ConverterTemperatura_Com_TemperaturaOrigem_F_TemperaturaDestino_C()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "f";
            temperatura.Temperaturaa = 300;
            temperatura.TemperaturaDestino = "c";

            // Act
            var temperaturaConvertida = temperatura.ConverterTemperatura();
            var temperaturaConvertidaEsperada = (300 - 32) / 1.8;

            // Assert
            temperaturaConvertida.Should().Be(temperaturaConvertidaEsperada);
        }

        [Fact]
        public void Validar_ConverterTemperatura_Com_TemperaturaOrigem_F_TemperaturaDestino_K()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = "f";
            temperatura.Temperaturaa = 300;
            temperatura.TemperaturaDestino = "k";

            // Act
            var temperaturaConvertida = temperatura.ConverterTemperatura();
            var temperaturaConvertidaEsperada = (300 - 32) / 1.8 +273;

            // Assert
            temperaturaConvertida.Should().Be(temperaturaConvertidaEsperada);
        }
    }
}
