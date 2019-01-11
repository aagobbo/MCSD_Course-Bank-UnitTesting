using BKG.Banco.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BKG.Banco.Test.Unit
{
    [TestClass]
    public class CarteiraSpec
    {
        [TestMethod]
        public void DeveAbrirContaCorrente()
        {
            //Arrange
            Carteira carteira = new Carteira();

            //Act
            var mock = new CestaMock();
            var contaCorrente = carteira.AbrirConta("1", "João", 100.0m, 1000.0m, mock);

            //Assert
            Assert.IsNotNull(contaCorrente);

        }

        [TestMethod]
        public void DeveAbrirContaPoupanca()
        {
            //Arrange
            Carteira carteira = new Carteira();

            //Act
            var contaPoupanca = carteira.AbrirConta("1", "João", 100.0m);

            //Assert
            Assert.IsNotNull(contaPoupanca);

        }
    }
}
