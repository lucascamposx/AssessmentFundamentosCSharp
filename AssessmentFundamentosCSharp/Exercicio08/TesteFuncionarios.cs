using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentFundamentosCSharp.Exercicio08
{
    class TesteFuncionarios
    {
        public void Main()
        {
            Funcionario funcionario = new Funcionario("Lucas", "Estagiario", 1000.00);
            Gerente gerente = new Gerente("Pedro", 5000.00);

            funcionario.ExibirDados();
            gerente.ExibirDados();
        }
    }
}
