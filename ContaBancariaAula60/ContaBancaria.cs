using System;
using System.Globalization;

namespace ContaBancariaAula60
{
    class ContaBancaria
    {
        // Propriedades autoimplementadas:                 
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // Criacao dos construtores com dois argumentos:
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;            
        }

        // Construtor, reaproitando os atributo acima, atraves da palavra this
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) // reaproitando o contrutuor de dois argumentos acima (numero e titular)
        {
            Deposito(depositoInicial);
        }

        // Metodos da Classe:
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }        
        // Criando o ToString:
        public override string ToString()
        {
            return "Conta: "
                   + Numero
                   + ", Titular: "
                   + Titular
                   + ", Saldo: $"
                   + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
