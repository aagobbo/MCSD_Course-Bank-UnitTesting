using BKG.Banco.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BKG.Banco.Test.Unit
{
    [TestClass]
    public class ContaCorrenteSpec
    {
        [TestMethod]
        public void DeveDepositarDinheiroNaConta()
        {
            //Arrange
            var mock = new CestaMock();
            Conta conta = new ContaCorrente("1", "1", "João", 100.0m, 100.0m, mock);

            //Act
            conta.Depositar(100.0m);

            //Assert
            Assert.AreEqual(200.0m, conta.Saldo);
        }

        [TestMethod]
        public void DeveSacarDinheiroDaContaComSaldo()
        {
            //Arrange
            var mock = new CestaMock();
            Conta conta = new ContaCorrente("1", "1", "João", 100.0m, 100.0m, mock);

            //Act
            conta.Sacar(50.0m);

            //Assert
            Assert.AreEqual(50.0m, conta.Saldo);
        }

        [TestMethod]
        public void DeveSacarDinheiroDaContaSemSaldo()
        {
            //Arrange
            var mock = new CestaMock();
            Conta conta = new ContaCorrente("1", "1", "João", 100.0m, 100.0m, mock);
            
            //Act
            //Assert
            Assert.ThrowsException<Exception>(() => conta.Sacar(150.0m));
        }
    }
}
