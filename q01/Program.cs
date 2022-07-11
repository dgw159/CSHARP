using System;
using System.Globalization;

namespace q01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            NumeroConta conta;

            Console.Write("Entre com o numero da conta: ");
            int nconta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o saldo da conta: ");
                double depositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new NumeroConta(nconta, nome, depositoinicial);
            }
            else
            {
                conta = new NumeroConta(nconta, nome);
            }

            Console.WriteLine(conta);

            Console.Write("Entre um valor de deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.AdicionarSaldo(quantia);
            Console.WriteLine(conta);

            Console.Write("Entre um valor de saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.RetirarSaldo(quantia);
            Console.WriteLine(conta);
        }
    }
}