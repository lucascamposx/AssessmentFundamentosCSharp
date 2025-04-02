using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentFundamentosCSharp.Exercicio08
{
    class Gerente : Funcionario
    {
        public Gerente( string nome, double salarioBase) : base(nome, "Gerente", salarioBase)
        {
        }

        public override double CalcularSalario()
        {
            return salarioBase * 1.2; // + 20% bônus
        }

    }
}
