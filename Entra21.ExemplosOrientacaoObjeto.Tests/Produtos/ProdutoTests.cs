﻿using Entra21.ExemplosOrientacaoObjeto.Produtos;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

//ctrl + shift + b -> Realizar antes de rodar o programa

namespace Entra21.ExemplosOrientacaoObjeto.Tests.Produtos
{
    public class ProdutoTests
    {
        [Fact] // ctrl + . -> xUnit -> referenciar
        public void Validar_EhVencido_Com_DataVencimento_Menor_Hoje()


        {
            // Arrange (preparar os dados)
            var produto = new Produto(); // ctrl + . -> referenciar método
            produto.DataVencimento = new DateTime(2022, 05, 04);

            // Act (ato de execução do método que deseja testar)
            var produtoVencido = produto.EhVencido();

            // Assert (validação do que foi gerado)
            // ctrl + . -> fluent assertion -> referenciar
            produtoVencido.Should().BeTrue();
            // ou pode escrever
            // produtoVencido.Should().Be(true);
        }

        [Fact]
        public void Validar_Eh_Vencido_Com_DataVencimento_Maior_Hoje()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(1);

            // Act
            var vencido = produto.EhVencido();

            // Assert
            vencido.Should().BeFalse();
        }

        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Hoje()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            // Act
            var vencido = produto.EhVencido();

            // Assert
            vencido.Should().BeTrue();
        }

        [Fact]
        public void Validar_EstaEmPromocao_Verdadeiro()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(3);

            // Act
            var emPromocao = produto.EstaEmPromocao();

            // Assert
            emPromocao.Should().BeTrue();
        }

        [Fact]
        public void Validar_EstaEmPromocao_False()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            // Act
            var emPromocao = produto.EstaEmPromocao();

            // Assert
            emPromocao.Should().BeFalse();
        }
    }
}
