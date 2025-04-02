using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentFundamentosCSharp.Exercicio08
{
    class Funcionario
    {
        public string nome;
        public string cargo;
        public double salarioBase;

        public Funcionario(string nome, string cargo, double salarioBase)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salarioBase = salarioBase;
        }

        public virtual double CalcularSalario()
        {
            return salarioBase;
        }

        public void ExibirDados()
        {
            Console.WriteLine("\nNome: " + nome);
            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("salarioBase: " + salarioBase);
            Console.WriteLine("Salario: " + CalcularSalario());
        }
    }
}
