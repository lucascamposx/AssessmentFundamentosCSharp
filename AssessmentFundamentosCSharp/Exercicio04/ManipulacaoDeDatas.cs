using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentFundamentosCSharp.Exercicio04
{
    class ManipulacaoDeDatas
    {
        public void Main()
        {
            Console.WriteLine("Digite sua Data de Nascimento: (dd/mm/aaaa)");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime dataNascimento))
            {
                DateTime dataAtual = DateTime.Now;

                DateTime proximoAniversario = new DateTime(dataAtual.Year, dataNascimento.Month, dataNascimento.Day);

                // Se o aniversario ja passou neste ano
                if (proximoAniversario < dataAtual)
                {
                    proximoAniversario = proximoAniversario.AddYears(1);
                }

                int diasAteAniversario = (proximoAniversario - dataAtual).Days;

                // Verificando se faltam menos de 7 dias
                if (diasAteAniversario < 7)
                {
                    Console.WriteLine($"\nFaltam apenas {diasAteAniversario} dias para o seu aniversário! Que emoção!");
                }
                else
                {
                    Console.WriteLine($"\nFaltam {diasAteAniversario} dias para o seu próximo aniversário.");
                }
            }
            else
            {
                Console.WriteLine("Formato invalido, use (dd/mm/aaaa)");
            }
        }
    }
}
