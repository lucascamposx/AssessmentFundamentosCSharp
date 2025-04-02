using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentFundamentosCSharp.Exercicio01
{
    class PrimeiroPrograma
    {
        public void Main()
        {
            string nome = "Lucas Campos";
            DateTime dataNascimento = new DateTime(2004, 5, 5);

            Console.WriteLine("Olá, meu nome é " + nome + "!");

            Console.WriteLine("Nasci em " + dataNascimento.ToString("dd/MM/yyyy") + " e estou aprendendo C#!");
        }
    }
} 
