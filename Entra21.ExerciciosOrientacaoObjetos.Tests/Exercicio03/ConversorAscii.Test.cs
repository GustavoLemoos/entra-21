using Entra21.ExerciciosOrientacaoObjetos.Exercicio03;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace Entra21.ExerciciosOrientacaoObjetos.Tests.Exercicio03
{
    public class ConversorAsciiTests
    {
        [Theory]
        [InlineData("a", 97)] [InlineData("b", 98)] [InlineData("d", 100)]
        [InlineData("t", 116)] [InlineData("T", 84)] [InlineData("r", 114)]
        public void Validar_ConverterCodigoAscii(string caractere, int codigoAscii)
        {
            ConversorAscii conversorAscii = new ConversorAscii();
            // Arrange
            conversorAscii.Caracteres = caractere;

            // Act
            var codigoConvertidoApresentado = conversorAscii.ConverterCodigoAscii();

            // Assert
            codigoConvertidoApresentado.Should().Be(codigoAscii);
        }
    }
}
