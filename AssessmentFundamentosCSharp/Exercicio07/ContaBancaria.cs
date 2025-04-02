using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentFundamentosCSharp.Exercicio07
{
    class ContaBancaria
    {
        public string titular;
        private decimal saldo;

        public ContaBancaria(string titular)
        {
            this.titular = titular;
            this.saldo = 0;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"\nDepósito de R$ {valor:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nO valor do depósito deve ser positivo!");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"\nSaque de R$ {valor:F2} realizado com sucesso!");
            }
            else if (valor > saldo)
            {
                Console.WriteLine($"\nTentativa de saque: R$ {valor:F2}");
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            }
            else if(valor < 0)
            {
                Console.WriteLine("\nValor Invalido, O valor do saque deve ser positivo");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"\nSaldo atual: R$ {saldo:F2}");
        }

        public void Main()
        {
            ContaBancaria conta = new ContaBancaria("João Silva");

            Console.WriteLine($"Titular: {conta.titular}");

            conta.Depositar(500);
            conta.ExibirSaldo();

            conta.Sacar(700);

            conta.Sacar(200);
            conta.ExibirSaldo();
        }
    }
}
