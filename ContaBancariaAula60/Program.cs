using System;
using System.Globalization;

namespace ContaBancariaAula60
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando a variavel conta:
            ContaBancaria conta;

            //ContaBancaria c = new ContaBancaria();

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            
            Console.Write("Haverá deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else conta = new ContaBancaria(numero, titular);
            Console.WriteLine();

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            
            // Imprimir na tela deposito:
            Console.Write("Entre com um valor para depósito: ");           
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);
            Console.WriteLine();

            // Imprimir na tela saque:
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);
            
        }
    }
}
