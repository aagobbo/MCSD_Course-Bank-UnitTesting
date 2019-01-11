namespace BKG.Banco.Dominio
{
    public abstract class Conta
    {
        public string NumeroAgencia { get; protected set; }
        public string NumeroConta { get; protected set; }
        public string NomeCliente { get; protected set; }
        public decimal Saldo { get; protected set; }

        public virtual void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }

        public virtual void Sacar(decimal valor) 
        {
            this.Saldo -= valor;
        }
    }
}