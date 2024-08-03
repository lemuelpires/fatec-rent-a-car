using System;
using Xunit;

namespace fatec_rent.API.Tests
{
    public class VeiculoTests
    {
        [Fact]
        public void Can_Create_Veiculo_With_Valid_Properties()
        {
            // Arrange
            var id = Guid.NewGuid();
            var categoria = "SUV";
            var modelo = "Modelo X";
            var capacidadePassageiros = 5;
            var combustivel = "Gasolina";
            var preco = 120000.50m;

            // Act
            var veiculo = new Veiculo
            {
                Id = id,
                Categoria = categoria,
                Modelo = modelo,
                CapacidadePassageiros = capacidadePassageiros,
                Combustivel = combustivel,
                Preco = preco
            };

            // Assert
            Assert.Equal(id, veiculo.Id);
            Assert.Equal(categoria, veiculo.Categoria);
            Assert.Equal(modelo, veiculo.Modelo);
            Assert.Equal(capacidadePassageiros, veiculo.CapacidadePassageiros);
            Assert.Equal(combustivel, veiculo.Combustivel);
            Assert.Equal(preco, veiculo.Preco);
        }

        [Fact]
        public void Veiculo_Default_Constructor_Sets_Properties_To_Default_Values()
        {
            // Act
            var veiculo = new Veiculo();

            // Assert
            Assert.Equal(default(Guid), veiculo.Id);
            Assert.Null(veiculo.Categoria);
            Assert.Null(veiculo.Modelo);
            Assert.Equal(default(int), veiculo.CapacidadePassageiros);
            Assert.Null(veiculo.Combustivel);
            Assert.Equal(default(decimal), veiculo.Preco);
        }

        [Fact]
        public void Veiculo_Setters_Correctly_Assign_Values()
        {
            // Arrange
            var veiculo = new Veiculo();
            var id = Guid.NewGuid();
            var categoria = "Sedan";
            var modelo = "Modelo Y";
            var capacidadePassageiros = 4;
            var combustivel = "Diesel";
            var preco = 80000.00m;

            // Act
            veiculo.Id = id;
            veiculo.Categoria = categoria;
            veiculo.Modelo = modelo;
            veiculo.CapacidadePassageiros = capacidadePassageiros;
            veiculo.Combustivel = combustivel;
            veiculo.Preco = preco;

            // Assert
            Assert.Equal(id, veiculo.Id);
            Assert.Equal(categoria, veiculo.Categoria);
            Assert.Equal(modelo, veiculo.Modelo);
            Assert.Equal(capacidadePassageiros, veiculo.CapacidadePassageiros);
            Assert.Equal(combustivel, veiculo.Combustivel);
            Assert.Equal(preco, veiculo.Preco);
        }
    }
}
