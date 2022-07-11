using System.Globalization;

namespace q01
{
    class NumeroConta
    {
        public int Nconta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public NumeroConta(int nconta, string nome)
        {
            Nconta = nconta;
            Nome = nome;
        }
        public NumeroConta(int nconta, string nome, double saldo) : this(nconta, nome)
        {
            Saldo = saldo;
        }

        public void AdicionarSaldo(double saldo)
        {
            Saldo += saldo;
        }
        public void RetirarSaldo(double saldo)
        {
            Saldo = Saldo - saldo - 5;
        }

        public override string ToString()
        {
            return "Conta: " + Nconta + ", Titular: " + Nome + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}