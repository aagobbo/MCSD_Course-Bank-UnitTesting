using System;

namespace BKG.Banco.Dominio
{
    public class ContaCorrente : Conta
    {

        public decimal Limite { get; private set; }
        public Cesta Cesta { get; private set; }

        public ContaCorrente(string numeroAgencia, string numeroConta, string nomeCliente, decimal saldoInicial, decimal limite, Cesta cesta)
        {
            this.NumeroAgencia = numeroAgencia;
            this.NumeroConta = numeroConta;
            this.NomeCliente = nomeCliente;
            this.Saldo = saldoInicial;
            this.Limite = limite;
            this.Cesta = cesta;
        }
        public override void Sacar(decimal valor)
        {
            if (valor > this.Saldo)
                throw new Exception("Saldo insuficiente");
            base.Sacar(valor);
        }
    }
}