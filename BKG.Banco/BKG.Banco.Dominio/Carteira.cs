using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BKG.Banco.Dominio
{
    public class Carteira
    {
        private List<ContaCorrente> contasCorrentes = new List<ContaCorrente>();
        public IReadOnlyCollection<ContaCorrente> ContasCorrentes => new  ReadOnlyCollection<ContaCorrente>(contasCorrentes);
        private List<ContaPoupanca> contasPoupancas = new List<ContaPoupanca>();
        public IReadOnlyCollection<ContaPoupanca> ContasPoupancas => new ReadOnlyCollection<ContaPoupanca>(contasPoupancas);
        
        public ContaCorrente AbrirConta(string numeroAgencia, string nomeCliente, decimal saldoInicial, decimal limite, Cesta cesta)
        {
            ContaCorrente conta = new ContaCorrente(numeroAgencia, contasCorrentes.Count.ToString(), nomeCliente, saldoInicial, limite, cesta); ;
            contasCorrentes.Add(conta);
            return conta;
        }
        public ContaPoupanca AbrirConta(string numeroAgencia, string nomeCliente, decimal saldoInicial) {
            ContaPoupanca conta = new ContaPoupanca(numeroAgencia, contasPoupancas.Count.ToString(), nomeCliente, saldoInicial);
            contasPoupancas.Add(conta);
            return conta;

        }

    }
}