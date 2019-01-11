using System;

namespace BKG.Banco.Dominio
{
    public class ContaPoupanca : Conta
    {

        

        public ContaPoupanca(string numeroAgencia, string numeroConta, string nomeCliente, decimal saldoInicial)
        {
            this.NumeroAgencia = numeroAgencia;
            this.NumeroConta = numeroConta;
            this.NomeCliente = nomeCliente;
            this.Saldo = saldoInicial;
        }

        public override void Sacar(decimal valor)
        {
            if (valor > this.Saldo)
                throw new Exception("Saldo insuficiente");
            base.Sacar(valor);
        }
    }
}